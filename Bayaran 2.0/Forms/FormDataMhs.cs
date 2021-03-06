﻿using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using Exainsane.Lib;
using Inventory.Model;
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
    public partial class FormDataMhs : Form
    {
        ControllerMhs Controller;
        public FormDataMhs()
        {
            InitializeComponent();
            

            Controller = new ControllerMhs();
            Controller.DataLoaded += Controller_DataLoaded;

            ubahDataToolStripMenuItem.Click += ubahDataToolStripMenuItem_Click;
            hapusToolStripMenuItem.Click += hapusToolStripMenuItem_Click;
        }        
        private void FormDataMhs_Load(object sender, EventArgs e)
        {
            Controller.Load();
            //var Assembly = System.Reflection.Assembly.GetExecutingAssembly();        
            AppCentre.SetButtonIcon(Properties.Resources.ic_new, ref btnew);            
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
            inp.Fill<DataStructure.ms_mhs>(data);
            Manipulator.DumpObject(data);
            inp.OnFinishEditing += (control, isnew) =>
            {
                var ndata = Manipulator.FetchControlTo<DataStructure.ms_mhs>(control);

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
            foreach (DataGridViewRow r in gridmhs.Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }
        DataStructure.ms_mhs GetSelectedData()
        {
            int rindex = gridmhs.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rindex < 0) return null;
            var data = gridmhs.DataSource as List<DataStructure.ms_mhs>;
            return data[rindex];

        }

        void Controller_DataLoaded()
        {
            Invoke(new Action(() =>
            {
                gridmhs.DataSource = Controller.Data;
            }));
        }
        private void btnew_Click(object sender, EventArgs e)
        {
            inputform inf = new inputform(new DataStructure.ms_mhs(), "Data Mahasiswa");
            inf.Show();
            inf.OnFinishEditing += (obj,isnew) =>
            {
                var data = Manipulator.FetchControlTo<DataStructure.ms_mhs>(obj);
                Manipulator.DumpObject(data);
                if (Query.Insert<DataStructure.ms_mhs>(data) > 0)
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
                gridmhs.ClearSelection();
                var row = gridmhs.HitTest(e.X, e.Y);
                if (row.RowIndex < 0) return;

                gridmhs.Rows[row.RowIndex].Selected = true;
                rmenu.Show(Cursor.Position);
            }
        }

        private void bfilter_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Controller.Filter(bfilter.Text);
        }
#endregion
    }
}
