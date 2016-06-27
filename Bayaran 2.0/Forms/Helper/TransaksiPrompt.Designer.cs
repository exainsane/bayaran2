namespace Bayaran_2._0.Forms.Helper
{
    partial class TransaksiPrompt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipetransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rincianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trbayarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bexit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbayarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipetransaksiDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.rincianDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.idmhsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trbayarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(598, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.FillWeight = 35F;
            this.idDataGridViewTextBoxColumn.HeaderText = "No";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipetransaksiDataGridViewTextBoxColumn
            // 
            this.tipetransaksiDataGridViewTextBoxColumn.DataPropertyName = "tipe_transaksi";
            this.tipetransaksiDataGridViewTextBoxColumn.HeaderText = "Jenis Transaksi";
            this.tipetransaksiDataGridViewTextBoxColumn.Name = "tipetransaksiDataGridViewTextBoxColumn";
            this.tipetransaksiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominalDataGridViewTextBoxColumn
            // 
            this.nominalDataGridViewTextBoxColumn.DataPropertyName = "nominal";
            this.nominalDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalDataGridViewTextBoxColumn.Name = "nominalDataGridViewTextBoxColumn";
            this.nominalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rincianDataGridViewTextBoxColumn
            // 
            this.rincianDataGridViewTextBoxColumn.DataPropertyName = "rincian";
            this.rincianDataGridViewTextBoxColumn.HeaderText = "Rincian";
            this.rincianDataGridViewTextBoxColumn.Name = "rincianDataGridViewTextBoxColumn";
            this.rincianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trbayarBindingSource
            // 
            this.trbayarBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.tr_bayar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sebelum melanjutkan, silahkan cek apakah data yang di input\r\nsesuai? Data yang te" +
    "lah di input tidak dapat diubah kembali.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label2.Location = new System.Drawing.Point(376, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // ltotal
            // 
            this.ltotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotal.Location = new System.Drawing.Point(416, 263);
            this.ltotal.Name = "ltotal";
            this.ltotal.Size = new System.Drawing.Size(197, 25);
            this.ltotal.TabIndex = 1;
            this.ltotal.Text = "Total";
            this.ltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ya, data sesuai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tidak";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 137;
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(489, 321);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(124, 23);
            this.bexit.TabIndex = 2;
            this.bexit.Text = "Tutup";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 137;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 137;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 137;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 137;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 137;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 137;
            // 
            // idmhsDataGridViewTextBoxColumn
            // 
            this.idmhsDataGridViewTextBoxColumn.DataPropertyName = "id_mhs";
            this.idmhsDataGridViewTextBoxColumn.HeaderText = "Mahasiswa";
            this.idmhsDataGridViewTextBoxColumn.Name = "idmhsDataGridViewTextBoxColumn";
            this.idmhsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransaksiPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(625, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ltotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransaksiPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cek kembali data...";
            this.Load += new System.EventHandler(this.TransaksiPrompt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbayarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trbayarBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ltotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipetransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rincianDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}