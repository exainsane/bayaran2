using Bayaran_2._0.Forms.Reporting;
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
    public partial class Startup : Form
    {
        FormDataMhs FormMhs;
        GolonganBayaran FormGolongan;
        FormNomalUmum FormNominalU;
        FormTipeTransaksi FormTTransaksi;
        FormAssignGolongan FormAssign;
        FormNominalKhusus FormNominalK;
        Transaksi FormTransaksi;
        ReportStart FormReportStart;
        Importer FormImporter;
        public Startup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start<FormDataMhs>(ref FormMhs);
        }
        #region Jumper Method
        private void Start<T>(ref T f) where T : new()
        {            
            if ((f as Form) == null || (f as Form).IsDisposed)
                f = new T();

            (f as Form).Show();
            (f as Form).Focus();
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            Start<GolonganBayaran>(ref FormGolongan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start<FormTipeTransaksi>(ref FormTTransaksi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start<FormNomalUmum>(ref FormNominalU);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Start<FormNominalKhusus>(ref FormNominalK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Start<FormAssignGolongan>(ref FormAssign);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Start<Transaksi>(ref FormTransaksi);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Start<ReportStart>(ref FormReportStart);
        }

        private void button9_Click(object sender, EventArgs e)
        {            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Start<Importer>(ref FormImporter);
        }
    }
}
