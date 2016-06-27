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

namespace Bayaran_2._0.Forms
{
    public partial class LogTransaksi : Form
    {
        ControllerLog controller;
        public LogTransaksi()
        {
            InitializeComponent();

            controller = new ControllerLog();

            controller.DataLoaded += controller_DataLoaded;
        }

        void controller_DataLoaded()
        {
            Invoke(new Action(() =>
            {
                maindg.DataSource = controller.Data;
            }));
        }

        private void LogTransaksi_Load(object sender, EventArgs e)
        {
            controller.Load();
        }
        Helper.TransaksiPrompt dtwindow = null;
        private void maindg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            var idata = maindg.DataSource as List<ControllerLog.LogSummaryData>;
            var id = idata[e.RowIndex];
            if (idata.Count < 1) return;
            List<DataStructure.tr_bayar> dtbayar = controller.GetDataPembayaran(id.invcode);

            if (dtwindow == null || dtwindow.IsDisposed)
            {
                dtwindow = new Helper.TransaksiPrompt(dtbayar);
                dtwindow.SetViewMode = true;
            }
            else
            {                
                dtwindow.Reload(dtbayar);
            }

            Point p = Cursor.Position;
            Point lr = new Point(p.X + dtwindow.Width, p.Y);            
            if(!Screen.AllScreens.Any(s=>s.WorkingArea.Contains(lr)))
            {            
                p.X -= dtwindow.Width;                
            }

            Point tb = new Point(p.X, p.Y + dtwindow.Height);
            if (!Screen.AllScreens.Any(s => s.WorkingArea.Contains(tb)))
            {
                p.Y -= dtwindow.Height;
            }
            dtwindow.Location = p;
            dtwindow.Show();
            dtwindow.Focus();
            dtwindow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
