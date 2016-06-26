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
    public partial class GolonganBayaran : Form
    {
        ControllerGolongan Controller;
        public GolonganBayaran()
        {
            InitializeComponent();

            Controller = new ControllerGolongan();
            Controller.DataLoaded += Controller_DataLoaded;

            ubahDataToolStripMenuItem.Click += ubahDataToolStripMenuItem_Click;
            hapusToolStripMenuItem.Click += hapusToolStripMenuItem_Click;
        }

        private void GolonganBayaran_Load(object sender, EventArgs e)
        {
            Controller.Load();
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
            inputform inp = new inputform(new DataStructure.ms_mhs(), "Ubah Data Mahasiswa", true);
            inp.Show();
            inp.Fill<DataStructure.ms_golongan>(data);            
            inp.OnFinishEditing += (control, isnew) =>
            {
                var ndata = Manipulator.FetchControlTo<DataStructure.ms_golongan>(control);

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
            foreach (DataGridViewRow r in gridgolongan.Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }
        DataStructure.ms_golongan GetSelectedData()
        {
            int rindex = gridgolongan.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rindex < 0) return null;
            var data = gridgolongan.DataSource as List<DataStructure.ms_golongan>;
            return data[rindex];

        }

        void Controller_DataLoaded()
        {
            Invoke(new Action(() =>
            {
                gridgolongan.DataSource = Controller.Data;
            }));
        }
        private void btnew_Click(object sender, EventArgs e)
        {
            inputform inf = new inputform(new DataStructure.ms_golongan(), "Data Golongan");
            inf.Show();
            inf.OnFinishEditing += (obj, isnew) =>
            {
                var data = Manipulator.FetchControlTo<DataStructure.ms_golongan>(obj);
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
                gridgolongan.ClearSelection();
                var row = gridgolongan.HitTest(e.X, e.Y);
                if (row.RowIndex < 0) return;

                gridgolongan.Rows[row.RowIndex].Selected = true;
                rmenu.Show(Cursor.Position);
            }
        }

        private void bfilter_KeyUp(object sender, KeyEventArgs e)
        {
            Controller.Filter(bfilter.Text);
        }
        #endregion

    }
}
