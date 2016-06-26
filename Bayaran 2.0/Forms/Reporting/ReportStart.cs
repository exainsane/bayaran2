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
    public partial class ReportStart : Form
    {
        ControllerReport controller;
        public ReportStart()
        {
            InitializeComponent();

            controller = new ControllerReport();

        }
        #region Form Startup Methods
        void CreateCBReport()
        {
            //Key type : type of ControllerReport.ReportType
            cbreporttype.DisplayMember = "Value";
            cbreporttype.ValueMember = "Key";
            cbreporttype.DataSource = new BindingSource(controller.ReportTypeList, null);
        }
        void CreateCBProdi()
        {
            //Key type : type of ControllerReport.ReportType                   
            cb_prodi.DataSource = new BindingSource(controller.GetProdi(), null);
        }
        void CreateCBJurusan()
        {
            //Key type : type of ControllerReport.ReportType                   
            cb_jurusan.DataSource = new BindingSource(controller.GetJurusan(), null);
        }
        void CreateCBFakultas()
        {
            //Key type : type of ControllerReport.ReportType                   
            cb_fakultas.DataSource = new BindingSource(controller.GetFakultas(), null);
        }
        void CreateCBAngkatan()
        {
            //Key type : type of ControllerReport.ReportType                   
            cb_angkatan.DataSource = new BindingSource(controller.GetAngkatan(), null);
        }
        void SetupFilterEnabler()
        {
            ck_angkatan.Click += (x, y) =>
            {
                cb_angkatan.Enabled = (x as CheckBox).Checked;
            };
            ck_fakultas.Click += (x, y) =>
            {
                cb_fakultas.Enabled = (x as CheckBox).Checked;
            };
            ck_jurusan.Click += (x, y) =>
            {
                cb_jurusan.Enabled = (x as CheckBox).Checked;
            };
            ck_prodi.Click += (x, y) =>
            {
                cb_prodi.Enabled = (x as CheckBox).Checked;
            };
        }
        #endregion
        #region Wrapper        
        #endregion
        private void ReportStart_Load(object sender, EventArgs e)
        {
            //Call form startup methods
            CreateCBReport();
            CreateCBProdi();
            CreateCBJurusan();
            CreateCBFakultas();
            CreateCBAngkatan();
            SetupFilterEnabler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportStructure.ReportQuery Q = new ReportStructure.ReportQuery();

            Q.angkatan = Convert.ToInt32(cb_angkatan.SelectedValue);
            Q._angkatan = ck_angkatan.Checked;

            Q.fakultas = cb_fakultas.SelectedValue.ToString();
            Q._fakultas = ck_fakultas.Checked;

            Q.jurusan = cb_jurusan.SelectedValue.ToString();
            Q._jurusan = ck_jurusan.Checked;

            Q.prodi = cb_prodi.SelectedValue.ToString();
            Q._prodi = ck_prodi.Checked;

            Q.ReportType = (ControllerReport.ReportType)cbreporttype.SelectedValue;
            Q.dateto = dateto.Value;
            Q.datefrom = datefrom.Value;

            ReportFrame rframe = new ReportFrame(ref controller, Q);
            rframe.ShowDialog();
        }
    }
}
