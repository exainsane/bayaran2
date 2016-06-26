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
    public partial class FormNomalUmum : Form
    {
        ControllerNominalUmum Controller;
        public FormNomalUmum()
        {
            InitializeComponent();

            Controller = new ControllerNominalUmum();
            Controller.DataLoaded += Controller_DataLoaded;

            ubahDataToolStripMenuItem.Click += ubahDataToolStripMenuItem_Click;
            hapusToolStripMenuItem.Click += hapusToolStripMenuItem_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormNomalUmum_Load(object sender, EventArgs e)
        {
            Controller.Load();
            AppCentre.SetButtonIcon(Properties.Resources.ic_new, ref bnew);
        }
        #region DATA OPERATION
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
            inputform inp = new inputform(new DataStructure.ms_nominal_umum(), "Ubah Data Nominal", true);
            inp.Show();
            inp.Fill<DataStructure.ms_nominal_umum>(data);
            inp.OnFinishEditing += (control, isnew) =>
            {
                var ndata = Manipulator.FetchControlTo<DataStructure.ms_nominal_umum>(control);

                if (Controller.Update(ndata))
                {
                    inp.Hide();
                    inp.Dispose();

                    AppCentre.Inform("Data diupdate!", "Informasi");
                }
                Controller.Load();

            };
        }
        void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in gridnominal.Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }
        DataStructure.ms_nominal_umum GetSelectedData()
        {
            int rindex = gridnominal.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rindex < 0) return null;
            var data = gridnominal.DataSource as List<DataStructure.ms_nominal_umum>;
            return data[rindex];

        }

        void Controller_DataLoaded()
        {
            Invoke(new Action(() =>
            {
                gridnominal.DataSource = Controller.Data;
            }));
        }
        private void btnew_Click(object sender, EventArgs e)
        {
            inputform inf = new inputform(new DataStructure.ms_nominal_umum(), "Data Nominal Umum");
            inf.Show();
            inf.OnFinishEditing += (obj, isnew) =>
            {
                var data = Manipulator.FetchControlTo<DataStructure.ms_nominal_umum>(obj);
                Manipulator.DumpObject(data);
                if (Controller.Insert(data))
                {
                    inf.Hide();
                    inf.Dispose();

                    AppCentre.Inform("Data tersimpan!", "Informasi");
                }
                Controller.Load();
            };
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
            //Controller.Filter(bfilter.Text);
        }
        #endregion
    }
}
