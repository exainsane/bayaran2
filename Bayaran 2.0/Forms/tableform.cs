using Bayaran_2._0.Forms;
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
using System.Threading;
using System.Windows.Forms;

namespace Bayaran_2._0
{
    public partial class tableform : Form
    {
        Thread DataLoaderThread;
        public tableform()
        {
            InitializeComponent();
            InitiateContext();
        }
        private void InitiateContext()
        {
            rmedit.Click += rmedit_Click;
        }

        void rmedit_Click(object sender, EventArgs e)
        {
            var input = new inputform(new DataStructure.ms_type_transaksi(), "Tipe Transaksi");
            input.Show();
            var dt = (dataGridView1.DataSource as List<DataStructure.ms_type_transaksi>)[dataGridView1.SelectedRows[0].Index];
            input.Fill<DataStructure.ms_type_transaksi>(dt);
            input.OnFinishEditing += input_OnFinishEditing;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var input = new inputform(new DataStructure.ms_type_transaksi(),"Tipe Transaksi");
            input.Show();
            input.OnFinishEditing += input_OnFinishEditing;
        }

        void input_OnFinishEditing(Control c, bool newdata)
        {            
            var m = Manipulator.FetchControlTo<DataStructure.ms_type_transaksi>(c);
            if (newdata)Query.Insert<DataStructure.ms_type_transaksi>(m);
            else Query.Update<DataStructure.ms_type_transaksi>(m);
            Console.WriteLine(Query.FinalQuery);
            LoadData();
        }

        private void tableform_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataLoaderThread = new Thread((ThreadStart)delegate
            {
                DataSet ds;
                Query.NewConnection().setQuery("SELECT * FROM ms_type_transaksi", out ds);
                var l = ListCreator.CreateList<DataStructure.ms_type_transaksi>(ds.Tables[0]);
                Invoke(new Action(() =>
                {
                    dataGridView1.DataSource = l;
                }));
            });
            DataLoaderThread.Start();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Right) return;

            dataGridView1.ClearSelection();
            var row = dataGridView1.HitTest(e.X, e.Y);
            if (row.RowIndex < 0) return;
            dataGridView1.Rows[row.RowIndex].Selected = true;

            rmenu.Show(Cursor.Position);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var t = new Transaksi())
            {
                t.ShowDialog();
            }
        }
    }
}
