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
    public partial class FormAssignGolongan : Form
    {
        ControllerAssignGolongan Controller;
        public FormAssignGolongan()
        {
            InitializeComponent();

            Controller = new ControllerAssignGolongan();
            Controller.DataLoaded +=Controller_DataLoaded;

            hapusToolStripMenuItem.Click += hapusToolStripMenuItem_Click;
            ubahDataToolStripMenuItem.Click +=ubahDataToolStripMenuItem_Click;
        }

        private void FormAssignGolongan_Load(object sender, EventArgs e)
        {
            Controller.Load();

            AppCentre.SetButtonIcon(Properties.Resources.ic_assign, ref bassign);
            AppCentre.SetButtonIcon(Properties.Resources.ic_batch_assign, ref bbatchassign);
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
            //inputform inp = new inputform(new DataStructure.as_mhs_golongan(), "Ubah Data", true);
            //inp.Show();
            //inp.Fill<DataStructure.as_mhs_golongan>(data);
            //inp.OnFinishEditing += (control, isnew) =>
            //{
            //    var ndata = Manipulator.FetchControlTo<DataStructure.as_mhs_golongan>(control);

            //    if (Controller.Update(ndata))
            //    {
            //        inp.Hide();
            //        inp.Dispose();

            //        AppCentre.Inform("Data diupdate!", "Informasi");
            //    }
            //    Controller.Load();

            //};
            FormAssignGolonganCRUD crudform = new FormAssignGolonganCRUD(ref Controller);
            crudform.Fill(data);
            crudform.ShowDialog();
        }
        void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in gridassigngol.Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }
        DataStructure.as_mhs_golongan GetSelectedData()
        {
            int rindex = gridassigngol.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rindex < 0) return null;
            var data = gridassigngol.DataSource as List<ControllerAssignGolongan.vw_assign_golongan>;
            return data[rindex].ToBasicAssign();

        }

        void Controller_DataLoaded()
        {
            Invoke(new Action(() =>
            {
                AppCentre.Log(Controller.Data.ToString());
                gridassigngol.DataSource = Controller.Data;
            }));
        }
        private void btnew_Click(object sender, EventArgs e)
        {
            //inputform inf = new inputform(new DataStructure.as_mhs_golongan(), "Data Tipe Transaksi");
            //inf.Show();
            //inf.OnFinishEditing += (obj, isnew) =>
            //{
            //    var data = Manipulator.FetchControlTo<DataStructure.as_mhs_golongan>(obj);
            //    if (Controller.Insert(data))
            //    {
            //        inf.Hide();
            //        inf.Dispose();

            //        AppCentre.Inform("Data tersimpan!", "Informasi");
            //    }
            //    Controller.Load();
            //};
            FormAssignGolonganCRUD fcrd = new FormAssignGolonganCRUD(ref this.Controller);
            fcrd.ShowDialog();
        }

        private void gridmhs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gridassigngol.ClearSelection();
                var row = gridassigngol.HitTest(e.X, e.Y);
                if (row.RowIndex < 0) return;

                gridassigngol.Rows[row.RowIndex].Selected = true;
                rmenu.Show(Cursor.Position);
            }
        }

        private void bfilter_KeyUp(object sender, KeyEventArgs e)
        {
            Controller.Filter(bfilter.Text);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            new FormAssignGolonganBatch(ref Controller).ShowDialog();
        }
    }    
}
