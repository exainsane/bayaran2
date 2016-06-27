namespace Bayaran_2._0.Forms
{
    partial class LogTransaksi
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
            this.maindg = new System.Windows.Forms.DataGridView();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logSummaryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logSummaryDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maindg
            // 
            this.maindg.AllowUserToAddRows = false;
            this.maindg.AllowUserToDeleteRows = false;
            this.maindg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maindg.AutoGenerateColumns = false;
            this.maindg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.maindg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.invcodeDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.mahasiswaDataGridViewTextBoxColumn,
            this.angkatanDataGridViewTextBoxColumn,
            this.jurusanDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn,
            this.fakultasDataGridViewTextBoxColumn});
            this.maindg.DataSource = this.logSummaryDataBindingSource;
            this.maindg.Location = new System.Drawing.Point(13, 40);
            this.maindg.Name = "maindg";
            this.maindg.ReadOnly = true;
            this.maindg.RowHeadersVisible = false;
            this.maindg.Size = new System.Drawing.Size(641, 259);
            this.maindg.TabIndex = 0;
            this.maindg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maindg_CellClick);
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invcodeDataGridViewTextBoxColumn
            // 
            this.invcodeDataGridViewTextBoxColumn.DataPropertyName = "invcode";
            this.invcodeDataGridViewTextBoxColumn.HeaderText = "Kode Invoice";
            this.invcodeDataGridViewTextBoxColumn.Name = "invcodeDataGridViewTextBoxColumn";
            this.invcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominalDataGridViewTextBoxColumn
            // 
            this.nominalDataGridViewTextBoxColumn.DataPropertyName = "nominal";
            this.nominalDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalDataGridViewTextBoxColumn.Name = "nominalDataGridViewTextBoxColumn";
            this.nominalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mahasiswaDataGridViewTextBoxColumn
            // 
            this.mahasiswaDataGridViewTextBoxColumn.DataPropertyName = "mahasiswa";
            this.mahasiswaDataGridViewTextBoxColumn.HeaderText = "Mahasiswa";
            this.mahasiswaDataGridViewTextBoxColumn.Name = "mahasiswaDataGridViewTextBoxColumn";
            this.mahasiswaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angkatanDataGridViewTextBoxColumn
            // 
            this.angkatanDataGridViewTextBoxColumn.DataPropertyName = "angkatan";
            this.angkatanDataGridViewTextBoxColumn.HeaderText = "Angkatan";
            this.angkatanDataGridViewTextBoxColumn.Name = "angkatanDataGridViewTextBoxColumn";
            this.angkatanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurusanDataGridViewTextBoxColumn
            // 
            this.jurusanDataGridViewTextBoxColumn.DataPropertyName = "jurusan";
            this.jurusanDataGridViewTextBoxColumn.HeaderText = "Jurusan";
            this.jurusanDataGridViewTextBoxColumn.Name = "jurusanDataGridViewTextBoxColumn";
            this.jurusanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodiDataGridViewTextBoxColumn
            // 
            this.prodiDataGridViewTextBoxColumn.DataPropertyName = "prodi";
            this.prodiDataGridViewTextBoxColumn.HeaderText = "Prodi";
            this.prodiDataGridViewTextBoxColumn.Name = "prodiDataGridViewTextBoxColumn";
            this.prodiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fakultasDataGridViewTextBoxColumn
            // 
            this.fakultasDataGridViewTextBoxColumn.DataPropertyName = "fakultas";
            this.fakultasDataGridViewTextBoxColumn.HeaderText = "Fakultas";
            this.fakultasDataGridViewTextBoxColumn.Name = "fakultasDataGridViewTextBoxColumn";
            this.fakultasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logSummaryDataBindingSource
            // 
            this.logSummaryDataBindingSource.DataSource = typeof(Bayaran_2._0.Controller.ControllerLog.LogSummaryData);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox1.Location = new System.Drawing.Point(54, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 21);
            this.textBox1.TabIndex = 2;
            // 
            // LogTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 311);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maindg);
            this.Name = "LogTransaksi";
            this.Text = "LogTransaksi";
            this.Load += new System.EventHandler(this.LogTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logSummaryDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView maindg;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource logSummaryDataBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}