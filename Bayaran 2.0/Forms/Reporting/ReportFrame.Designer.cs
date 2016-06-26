namespace Bayaran_2._0.Forms.Reporting
{
    partial class ReportFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportByMhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportByMhsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv
            // 
            this.rv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ds";
            reportDataSource1.Value = this.ReportByMhsBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Bayaran_2._0.Report.ReportPerMahasiswa.rdlc";
            this.rv.Location = new System.Drawing.Point(13, 13);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(812, 302);
            this.rv.TabIndex = 0;
            // 
            // ReportByMhsBindingSource
            // 
            this.ReportByMhsBindingSource.DataSource = typeof(Bayaran_2._0.Model.ReportStructure.ReportByMhs);
            // 
            // ReportFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 327);
            this.Controls.Add(this.rv);
            this.Name = "ReportFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFrame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportByMhsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource ReportByMhsBindingSource;
    }
}