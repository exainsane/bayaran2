using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using Exainsane.Lib;
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
   
    public partial class FormNominalKhusus : Form
    {
        ControllerNominalKhusus Controller;
        public FormNominalKhusus()
        {
            InitializeComponent();

            gridnominal.AutoGenerateColumns = false;
            Controller = new ControllerNominalKhusus();
            Controller.DataLoaded += Controller_DataLoaded;

            hapusToolStripMenuItem.Click += hapusToolStripMenuItem_Click;
            ubahDataToolStripMenuItem.Click+=ubahDataToolStripMenuItem_Click;

        }
        private void ClearForm()
        {
            gridnominal.ClearSelection();
            FetchMhsDetail(new DataStructure.ms_mhs());
        }
        private void FormNominalKhusus_Load(object sender, EventArgs e)
        {
            Controller.Load();

            {
                Dictionary<int, string> d = new Dictionary<int, string>();
                AppCentre.Log("Setting data");
                d.Add(-99, "-Semua-");
                foreach (var i in Controller.data_transtype)
                {
                    d.Add(i.id, i.tipe_transaksi);
                }
                cbtranstype.ValueMember = "Key";
                cbtranstype.DisplayMember = "Value";
                cbtranstype.DataSource = new BindingSource(d, null);
            }

            AppCentre.SetButtonIcon(Properties.Resources.ic_new, ref bnew);

            ClearForm();
        }
        void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in gridnominal.Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }
        DataStructure.as_nominal_khusus GetSelectedData()
        {
            int rindex = gridnominal.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rindex < 0) return null;
            var data = gridnominal.DataSource as List<DataStructure.as_nominal_khusus>;
            return data[rindex];

        }

        void Controller_DataLoaded()
        {
            
            Invoke(new Action(() =>
            {
                gridnominal.DataSource = null;    
                gridnominal.DataSource = Controller.Data;                
            }));
        }
        private void btnew_Click(object sender, EventArgs e)
        {
            //inputform inf = new inputform(new DataStructure.as_nominal_khusus(), "Data Nominal");
            //inf.Show();
            //inf.OnFinishEditing += (obj, isnew) =>
            //{
            //    var data = Manipulator.FetchControlTo<DataStructure.as_nominal_khusus>(obj);
            //    Manipulator.DumpObject(data);
            //    if (Controller.Insert(data))
            //    {
            //        inf.Hide();
            //        inf.Dispose();

            //        AppCentre.Inform("Data tersimpan!", "Informasi");
            //    }
            //    Controller.Load();
            //};
            new FormNominalKhususCRUD(ref Controller).ShowDialog();
        }

        private void gridmhs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gridnominal.ClearSelection();
                var row = gridnominal.HitTest(e.X, e.Y);
                if (row.RowIndex < 0) return;

                gridnominal.Rows[row.RowIndex].Selected = true;
                rmenu.Show(Cursor.Position);
            }
        }
        private void bfilter_KeyUp(object sender, KeyEventArgs e)
        {
            Controller.Filter(bfilter.Text, (int)cbtranstype.SelectedValue);
        }

        private void gridnominal_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void FetchGolDetail(DataStructure.ms_golongan data)
        {
            Manipulator.FetchClassTo<DataStructure.ms_golongan, GroupBox>(data, ref groupBox2);
        }
        private void FetchMhsDetail(DataStructure.ms_mhs data)
        {
            Manipulator.FetchClassTo<DataStructure.ms_mhs, GroupBox>(data, ref groupBox2);
        }
        void hapusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetSelectedData();
            if (Controller.Delete(data))
            {
                AppCentre.Inform("Data dihapus!", "Informasi");
            }
            Controller.Load();
        }

        void ubahDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetSelectedData();
            inputform inp = new inputform(new DataStructure.as_nominal_khusus(), "Ubah Data", true);
            inp.Show();
            inp.Fill<DataStructure.as_nominal_khusus>(data);
            inp.OnFinishEditing += (control, isnew) =>
            {
                var ndata = Manipulator.FetchControlTo<DataStructure.as_nominal_khusus>(control);

                if (Controller.Update(ndata))
                {
                    inp.Hide();
                    inp.Dispose();

                    AppCentre.Inform("Data diupdate!", "Informasi");
                }
                Controller.Load();

            };
        }
        private void gridnominal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (Controller.data_mhs == null) return;
            var data = (from d in Controller.data_mhs
                     where d.id == GetSelectedData().id_mhs.value
                     select d).ToList();
            if (data.Count < 1)
            {
                FetchMhsDetail(new DataStructure.ms_mhs());
            }
            else
            {
                FetchMhsDetail(data.First());
                var dg = (from d in Controller.data_assign_gol
                          where d.id_mhs.value == data.First().id
                          select d).ToList();
                if (dg.Count == 1)
                {
                    kode_golongan.Text = (from d in Controller.data_golongan
                                          where d.id == dg.First().golongan.value
                                          select d.kode_golongan).First();                    
                }
                var kdn = (from d in Controller.Data
                           where d.id_mhs.value == data.First().id
                           select d).ToList();
                if(kdn.Count < 1) goto quitif;
                isbeasiswa.Text = kdn.First().beasiswa == true ? "Ya" : "Tidak";
            quitif:
                return;
            }
        }

        private void cbtranstype_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox s = sender as ComboBox;
            if (s.SelectedIndex < 0) return;
            //Controller.FilterTipeTrans((int)s.SelectedValue, bfilter.Text);
            Controller.Filter(bfilter.Text, (int)cbtranstype.SelectedValue);
        }

        private void label2_Click(object sender, EventArgs e)
        {            
        }
    }
}
