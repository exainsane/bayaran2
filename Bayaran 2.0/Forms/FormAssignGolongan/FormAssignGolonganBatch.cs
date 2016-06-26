using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bayaran_2._0.Forms
{
    public partial class FormAssignGolonganBatch : Form
    {
        ControllerAssignGolongan Controller;
        public FormAssignGolonganBatch(ref ControllerAssignGolongan controller)
        {
            InitializeComponent();

            this.Controller = controller;
        }
        private void FormAssignGolonganBatch_Load(object sender, EventArgs e)
        {
            LoadAngkatanCB();
        }
        private bool IsAngkatanRegistered(int angk)
        {
            var c = (from d in Controller._dataassign
                     join m in Controller._datamhs
                         on d.id_mhs.value equals m.id
                     where m.angkatan == angk
                     select d).Count();
            return c != 0;

        }
        private void LoadAngkatanCB()
        {
            var angktdt = (from d in Controller._datamhs
                           group d.id by d.angkatan
                               into data
                               select new
                               {
                                   id=data.Key                                   
                               });
            if (angktdt.Count() < 1) return;
            Dictionary<int, int> dct = new Dictionary<int, int>();
            foreach (var item in angktdt)
            {
                if(!IsAngkatanRegistered(item.id))
                    dct.Add(item.id, item.id);
            }
            cangkatan.ValueMember = "Key";
            cangkatan.DisplayMember = "Value";
            cangkatan.DataSource = new BindingSource(dct, null);
        }
        private void LoadGolonganCB(int angkatan){
            var data = (from g in Controller._datagol
                            where g.angkatan==angkatan
                            select g).ToList();
            if (data.Count < 1) return;
            Dictionary<int, string> dct = new Dictionary<int, string>();
            foreach (var item in data)
            {
                dct.Add(item.id, item.kode_golongan);
            }
            cgol.ValueMember = "Key";
            cgol.DisplayMember = "Value";
            cgol.DataSource = new BindingSource(dct, null);
        }
        private void cangkatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cangkatan.SelectedIndex < 0) return;

            var selected =Convert.ToInt32(cangkatan.SelectedValue);

            LoadGolonganCB(selected);
            var chk = (from data in Controller._datamhs
                       where data.angkatan == selected
                       select data).ToList();
            dataGridView1.DataSource = chk;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }

        private void cgol_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cgol.SelectedIndex < 0) return;
            int selected = Convert.ToInt32(cgol.SelectedValue);

            var dtrans = (from dtn in Controller._datanomumum
                          where dtn.golongan.value == selected
                          select dtn).ToList();
            if (dtrans.Count < 1) return;
            ClearGolonganDetail();
            foreach (var i in dtrans)
            {
                AppendDetailNominal(i.tipetrans.ToString(), i.nominal);
            }
        }
        private void ClearGolonganDetail()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        private void AppendDetailNominal(string label, decimal nom)
        {

            Label l1 = new Label();
            l1.Font = new System.Drawing.Font("Calibri", 8.75F);
            l1.Location = new System.Drawing.Point(131, 2);
            l1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            l1.Size = new System.Drawing.Size(78, 23);
            l1.TabIndex = 1;
            l1.Text = nom.ToString("#,##0");
            l1.TextAlign = System.Drawing.ContentAlignment.TopRight;

            Label l2 = new Label();
            l2.AutoSize = false;
            l2.Font = new System.Drawing.Font("Calibri", 8.75F);
            l2.Location = new System.Drawing.Point(-1, 2);
            l2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            l2.Size = new System.Drawing.Size(126, 24);
            l2.TabIndex = 2;
            l2.Text = label;

            Panel lpn = new Panel();
            lpn.Controls.Add(l1);
            lpn.Controls.Add(l2);
            lpn.Location = new System.Drawing.Point(3, 3);
            lpn.Name = "panel1";
            lpn.Size = new System.Drawing.Size(212, 28);
            lpn.TabIndex = 0;

            flowLayoutPanel1.Controls.Add(lpn);
        }

        private void bassign_Click(object sender, EventArgs e)
        {
            int golid = Convert.ToInt32(cgol.SelectedValue);
            int angkatan = Convert.ToInt32(cangkatan.SelectedValue);

            var mhsakt = (from d in Controller._datamhs
                          where d.angkatan == angkatan
                          select d).ToList();
            List<DataStructure.as_mhs_golongan> datalist = new List<DataStructure.as_mhs_golongan>();
            foreach (var item in mhsakt)
            {
                var i = new DataStructure.as_mhs_golongan();
                i.id_mhs.value = item.id;
                i.golongan.value = golid;
                datalist.Add(i);
            }
            
            Controller.BatchDataInserted += (i) =>
            {
                Invoke(new Action(() =>
                {
                    if (i == -99891)
                    {
                        AppCentre.Inform("Data inserted", "Information");
                        Controller.Load();
                        Hide();
                        Dispose();
                    }
                    else
                        bapplybatch.Text = string.Format("Executing... {0}/{1}", i.ToString(), datalist.Count);
                }));
                
            };
            Controller.BatchInsert(datalist);

        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void cangkatan_DataSourceChanged(object sender, EventArgs e)
        {
            SetApplyButtonEnabled();
        }
        void SetApplyButtonEnabled()
        {
            bool enabled = cangkatan.DataSource == null || cgol.DataSource == null;
            AppCentre.Log((enabled + "" + (cangkatan.DataSource == null) + "" + (cgol.DataSource == null)));
            bassign.Enabled = !enabled;
        }
    }
}
