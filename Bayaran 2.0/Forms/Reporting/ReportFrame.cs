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

namespace Bayaran_2._0.Forms.Reporting
{
    public partial class ReportFrame : Form
    {
        ControllerReport controller;
        ReportStructure.ReportQuery querydata;
        public ReportFrame(ref ControllerReport controller, ReportStructure.ReportQuery querydata)
        {
            InitializeComponent();

            this.controller = controller;
            this.querydata = querydata;
        }

        private void ReportFrame_Load(object sender, EventArgs e)
        {
            if (!PrepareReport()) return;

            
        }

        bool PrepareReport()
        {
            switch (this.querydata.ReportType)
            {
                case ControllerReport.ReportType.ReportByMahasiswa:                    
                    rv.LocalReport.ReportEmbeddedResource = "Bayaran_2._0.Report.ReportPerMahasiswa.rdlc";
                    LoadLocalReportDataByMhs();
                    break;
                case ControllerReport.ReportType.ReportByTransaksi:
                    rv.LocalReport.ReportEmbeddedResource = "Bayaran_2._0.Report.ReportPerTransaksi.rdlc";
                    LoadLocalReportDataByTransaksi();
                    break;
                default:
                    return false;
            }
            return true;
        }
        void LoadLocalReportDataByMhs()
        {
            List<ReportStructure.ReportByMhs> data = controller.GetReportDataMahasiswa(this.querydata);

            rv.LocalReport.DataSources.Clear();
            rv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ds", new BindingSource(data, null)));
            rv.LocalReport.Refresh();
            rv.RefreshReport();
        }
        void LoadLocalReportDataByTransaksi()
        {
            List<ReportStructure.ReportByTransaksi> data = controller.GetReportDataTransaksi(this.querydata);

            rv.LocalReport.DataSources.Clear();
            rv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ds", new BindingSource(data, null)));
            rv.LocalReport.Refresh();
            rv.RefreshReport();
        }
    }
}
