namespace Bayaran_2._0.Forms
{
    partial class FormTipeTransaksi
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
            this.gridtipetransaksi = new System.Windows.Forms.DataGridView();
            this._numcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipetransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicilanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mstypetransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.rmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ubahDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridtipetransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mstypetransaksiBindingSource)).BeginInit();
            this.rmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridtipetransaksi
            // 
            this.gridtipetransaksi.AllowUserToAddRows = false;
            this.gridtipetransaksi.AllowUserToDeleteRows = false;
            this.gridtipetransaksi.AutoGenerateColumns = false;
            this.gridtipetransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridtipetransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtipetransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._numcolumn,
            this.tipetransaksiDataGridViewTextBoxColumn,
            this.cicilanDataGridViewCheckBoxColumn});
            this.gridtipetransaksi.DataSource = this.mstypetransaksiBindingSource;
            this.gridtipetransaksi.Location = new System.Drawing.Point(12, 37);
            this.gridtipetransaksi.Name = "gridtipetransaksi";
            this.gridtipetransaksi.ReadOnly = true;
            this.gridtipetransaksi.RowHeadersVisible = false;
            this.gridtipetransaksi.Size = new System.Drawing.Size(506, 255);
            this.gridtipetransaksi.TabIndex = 0;
            this.gridtipetransaksi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.gridtipetransaksi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridmhs_MouseDown);
            // 
            // _numcolumn
            // 
            this._numcolumn.FillWeight = 35F;
            this._numcolumn.HeaderText = "No";
            this._numcolumn.Name = "_numcolumn";
            this._numcolumn.ReadOnly = true;
            // 
            // tipetransaksiDataGridViewTextBoxColumn
            // 
            this.tipetransaksiDataGridViewTextBoxColumn.DataPropertyName = "tipe_transaksi";
            this.tipetransaksiDataGridViewTextBoxColumn.HeaderText = "Tipe Transaksi/Pembayaran";
            this.tipetransaksiDataGridViewTextBoxColumn.Name = "tipetransaksiDataGridViewTextBoxColumn";
            this.tipetransaksiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cicilanDataGridViewCheckBoxColumn
            // 
            this.cicilanDataGridViewCheckBoxColumn.DataPropertyName = "otp";
            this.cicilanDataGridViewCheckBoxColumn.HeaderText = "One-time Payment";
            this.cicilanDataGridViewCheckBoxColumn.Name = "cicilanDataGridViewCheckBoxColumn";
            this.cicilanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // mstypetransaksiBindingSource
            // 
            this.mstypetransaksiBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.ms_type_transaksi);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tambah Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnew_Click);
            // 
            // rmenu
            // 
            this.rmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ubahDataToolStripMenuItem,
            this.hapusToolStripMenuItem});
            this.rmenu.Name = "rmenu";
            this.rmenu.Size = new System.Drawing.Size(130, 48);
            // 
            // ubahDataToolStripMenuItem
            // 
            this.ubahDataToolStripMenuItem.Name = "ubahDataToolStripMenuItem";
            this.ubahDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ubahDataToolStripMenuItem.Text = "Ubah Data";
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hapusToolStripMenuItem.Text = "Hapus";
            // 
            // bfilter
            // 
            this.bfilter.Location = new System.Drawing.Point(63, 7);
            this.bfilter.Name = "bfilter";
            this.bfilter.Size = new System.Drawing.Size(187, 20);
            this.bfilter.TabIndex = 3;
            this.bfilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bfilter_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // FormTipeTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(530, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bfilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridtipetransaksi);
            this.Name = "FormTipeTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipe Transaksi/Pembayaran";
            this.Load += new System.EventHandler(this.FormTipeTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtipetransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mstypetransaksiBindingSource)).EndInit();
            this.rmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridtipetransaksi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip rmenu;
        private System.Windows.Forms.TextBox bfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ubahDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
        private System.Windows.Forms.BindingSource mstypetransaksiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipetransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cicilanDataGridViewCheckBoxColumn;
    }
}