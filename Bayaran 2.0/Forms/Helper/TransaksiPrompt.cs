using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Forms.Helper
{
    public partial class TransaksiPrompt : Form
    {
        private bool _vmode = false;
        public bool SetViewMode
        {
            set
            {
                _vmode = value;
            }
        }
        private List<DataStructure.tr_bayar> data;        
        public TransaksiPrompt(List<DataStructure.tr_bayar> data)
        {
            InitializeComponent();
            this.data = data;
        }
        public void Reload(List<DataStructure.tr_bayar> data)
        {
            this.data = data;
            TransaksiPrompt_Load(this, null);
        }
        private void TransaksiPrompt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.data;
            dataGridView1.AutoGenerateColumns = false;

            decimal total = 0;
            foreach (var i in this.data)
            {
                total += i.nominal;
            }

            ltotal.Text = "Rp. " + total.ToString("#,##0");

            if (_vmode)
            {
                button1.Hide();
                button2.Hide();
                label1.Hide();
                bexit.Show();
                this.Text = "Detail Transaksi";
            }
            else
            {
                bexit.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }
    }
}
