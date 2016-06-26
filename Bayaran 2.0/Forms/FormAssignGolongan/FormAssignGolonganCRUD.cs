using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Forms
{
    public partial class FormAssignGolonganCRUD : Form
    {
        ControllerAssignGolongan Controller;
        DataStructure.as_mhs_golongan editdata = null;
        bool mode_edit {
            get{
                return editdata != null;
            }
        }
        public FormAssignGolonganCRUD(ref ControllerAssignGolongan controller)
        {
            InitializeComponent();

            this.Controller = controller;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }
        public void Fill(DataStructure.as_mhs_golongan data)
        {
            editdata = data;
        }
        private void FormAssignGolonganCRUD_Load(object sender, EventArgs e)
        {
            ClearGolonganDetail();
            InstallAutoComplete();
            if (mode_edit) LoadEditMode();
        }
        void LoadEditMode()
        {            
            var mhs = (from d in Controller._datamhs
                       where d.id == editdata.id_mhs.value
                       select d).ToList();
            if (mhs.Count != 1) return;
            tbnim.Text = mhs.First().nim;
            tbnim_KeyUp(this.tbnim, null);

            cgol.DataSourceChanged += (s, e) =>
            {
                cgol.SelectedValue = editdata.golongan.value;
            };
        }
        void InstallAutoComplete()
        {
            tbnim.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbnim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbnim.AutoCompleteCustomSource = Controller.GetMhsAutoCompleteStrings();
        }
        private bool Like(object o, string str)
        {
            return o.ToString().ToLower().Contains(str.ToLower());
        }
        private void tbnim_KeyUp(object sender, KeyEventArgs e)
        {            
            if (Controller._datamhs.Count < 1) return;

            string qstr = tbnim.Text;
            var q = (from mhs in Controller._datamhs                     
                     where mhs.nim.Equals(qstr)
                     select mhs).ToList();
            
            if (q.Count < 1)
            {
                l_errornim.Text = "Data tidak ditemukan!";
                goto clearup;
            }

            if (mode_edit) goto proc_ok;

            var chk = (from asg in Controller._dataassign
                       where asg.id_mhs.value == q.First().id
                       select asg).Count();
            if (chk != 0)
            {
                l_errornim.Text = "Data telah di assign!";
                goto clearup;
            }

            proc_ok:
            l_errornim.Text = "";
            FillMhsFormDetail(q.First());
            return;

            clearup:
            ClearMhsFormDetail();
            ClearComboGolongan();            
            return;
        }
        private void ClearMhsFormDetail()
        {
            string clr = "";
            l_angkatan.Text = clr;
            l_jurusan.Text = clr;
            l_nama.Text = clr;
            l_nim.Text = clr;
            l_prodi.Text = clr;
        }
        private void FillMhsFormDetail(DataStructure.ms_mhs data)
        {
            l_angkatan.Text = data.angkatan.ToString();
            l_jurusan.Text = data.jurusan;
            l_nama.Text = data.nama;
            l_nim.Text = data.nim;
            l_prodi.Text = data.prodi;

            FillComboGolongan(data.angkatan);
        }
        private void ClearComboGolongan()
        {
            cgol.DataSource = null;
        }
        private void FillComboGolongan(int angkatan, int defaultvalue = -1)
        {
            if (Controller._datagol.Count < 1) return;

            var qgol = (from g in Controller._datagol
                        where g.angkatan == angkatan
                        select g).ToList();

            Dictionary<int, string> dct = new Dictionary<int, string>();
            foreach (var i in qgol){
                dct.Add(i.id, i.kode_golongan);
            }
            cgol.DisplayMember = "Value";
            cgol.ValueMember = "Key";
            cgol.DataSource = new BindingSource(dct, null);
            if(editdata!=null){                
                var ck = (from d in qgol
                          where d.id == editdata.golongan.value
                          select d).ToList();
                if (ck.Count != 1) return;
                cgol.SelectedValue = editdata.golongan.value;
                cgol_SelectedIndexChanged(this.cgol, null);
                            
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
        private void AppendDetailNominal(string label, decimal nom){
            
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

        private bool isReadyToAssign()
        {
            var chk = (from d in Controller._datamhs
                       where d.nim.Equals(tbnim.Text)
                       select d).Count() == 1;
            var chk2 = (from d in Controller._datagol
                        where d.id == Convert.ToInt32(cgol.SelectedValue)
                        select d).Count() == 1;
            return chk && chk2;
        }
        private int GetMhsId(string nim)
        {
            var chk = (from d in Controller._datamhs
                       where d.nim.Equals(nim)
                       select d).ToList() ;
            if (chk.Count < 1) return -1;
            else return chk.First().id;
        }
        private void bassign_Click(object sender, EventArgs e)
        {
            if (!isReadyToAssign())
            {
                MessageBox.Show("Cek kembali input!", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataStructure.as_mhs_golongan data_assign;
            if (editdata != null)
            {
                data_assign = editdata;
            }
            else
            {
                data_assign = new DataStructure.as_mhs_golongan();
            }
            int idmhs = GetMhsId(tbnim.Text);
            int idgol = Convert.ToInt32(cgol.SelectedValue);
            data_assign.id_mhs.value = idmhs;
            data_assign.golongan.value = idgol;
            bool apply = !mode_edit?Controller.Insert(data_assign):Controller.Update(data_assign);
            if (apply)
            {
                AppCentre.Inform("Data telah di input!", "Informasi");
                Controller.Load();
                Hide();
                Dispose();
            }
            else
            {
                AppCentre.Inform("Data gagal di input!", "Informasi");
            }


        }

        private void cgol_DataSourceChanged(object sender, EventArgs e)
        {
            bool enabled = cgol.DataSource == null;
            bassign.Enabled = !enabled;
        }
    }
}
