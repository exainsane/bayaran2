namespace Bayaran_2._0.Forms
{
    partial class GolonganBayaran
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
            this.gridgolongan = new System.Windows.Forms.DataGridView();
            this._numcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_golongan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodegolonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgolonganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trbayarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnew = new System.Windows.Forms.Button();
            this.rmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ubahDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridgolongan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgolonganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbayarBindingSource)).BeginInit();
            this.rmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridgolongan
            // 
            this.gridgolongan.AllowUserToAddRows = false;
            this.gridgolongan.AllowUserToDeleteRows = false;
            this.gridgolongan.AllowUserToOrderColumns = true;
            this.gridgolongan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridgolongan.AutoGenerateColumns = false;
            this.gridgolongan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridgolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridgolongan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._numcolumn,
            this.kode_golongan,
            this.angkatan,
            this.kodegolonganDataGridViewTextBoxColumn,
            this.angkatanDataGridViewTextBoxColumn});
            this.gridgolongan.DataSource = this.msgolonganBindingSource;
            this.gridgolongan.Location = new System.Drawing.Point(13, 45);
            this.gridgolongan.Name = "gridgolongan";
            this.gridgolongan.RowHeadersVisible = false;
            this.gridgolongan.Size = new System.Drawing.Size(519, 204);
            this.gridgolongan.TabIndex = 0;
            this.gridgolongan.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.gridgolongan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridmhs_MouseDown);
            // 
            // _numcolumn
            // 
            this._numcolumn.FillWeight = 32F;
            this._numcolumn.HeaderText = "No";
            this._numcolumn.Name = "_numcolumn";
            this._numcolumn.ReadOnly = true;
            // 
            // kode_golongan
            // 
            this.kode_golongan.DataPropertyName = "kode_golongan";
            this.kode_golongan.HeaderText = "Kode Golongan";
            this.kode_golongan.Name = "kode_golongan";
            this.kode_golongan.ReadOnly = true;
            // 
            // angkatan
            // 
            this.angkatan.DataPropertyName = "angkatan";
            this.angkatan.HeaderText = "Angkatan";
            this.angkatan.Name = "angkatan";
            this.angkatan.ReadOnly = true;
            // 
            // kodegolonganDataGridViewTextBoxColumn
            // 
            this.kodegolonganDataGridViewTextBoxColumn.DataPropertyName = "kode_golongan";
            this.kodegolonganDataGridViewTextBoxColumn.HeaderText = "Kode Golongan";
            this.kodegolonganDataGridViewTextBoxColumn.Name = "kodegolonganDataGridViewTextBoxColumn";
            // 
            // angkatanDataGridViewTextBoxColumn
            // 
            this.angkatanDataGridViewTextBoxColumn.DataPropertyName = "angkatan";
            this.angkatanDataGridViewTextBoxColumn.HeaderText = "Angkatan";
            this.angkatanDataGridViewTextBoxColumn.Name = "angkatanDataGridViewTextBoxColumn";
            // 
            // msgolonganBindingSource
            // 
            this.msgolonganBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.ms_golongan);
            // 
            // trbayarBindingSource
            // 
            this.trbayarBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.tr_bayar);
            // 
            // bnew
            // 
            this.bnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnew.Location = new System.Drawing.Point(422, 13);
            this.bnew.Name = "bnew";
            this.bnew.Size = new System.Drawing.Size(109, 23);
            this.bnew.TabIndex = 1;
            this.bnew.Text = "Tambah Data";
            this.bnew.UseVisualStyleBackColor = true;
            this.bnew.Click += new System.EventHandler(this.btnew_Click);
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
            this.bfilter.Location = new System.Drawing.Point(55, 15);
            this.bfilter.Name = "bfilter";
            this.bfilter.Size = new System.Drawing.Size(124, 20);
            this.bfilter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // GolonganBayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bfilter);
            this.Controls.Add(this.bnew);
            this.Controls.Add(this.gridgolongan);
            this.Name = "GolonganBayaran";
            this.Text = "Golongan Pembayaran";
            this.Load += new System.EventHandler(this.GolonganBayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridgolongan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgolonganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbayarBindingSource)).EndInit();
            this.rmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridgolongan;
        private System.Windows.Forms.BindingSource msgolonganBindingSource;
        private System.Windows.Forms.BindingSource trbayarBindingSource;
        private System.Windows.Forms.Button bnew;
        private System.Windows.Forms.ContextMenuStrip rmenu;
        private System.Windows.Forms.ToolStripMenuItem ubahDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
        private System.Windows.Forms.TextBox bfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_golongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodegolonganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatanDataGridViewTextBoxColumn;
    }
}