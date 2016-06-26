namespace Bayaran_2._0.Forms
{
    partial class FormDataMhs
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
            this.gridmhs = new System.Windows.Forms.DataGridView();
            this._numcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnew = new System.Windows.Forms.Button();
            this.rmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ubahDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridmhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).BeginInit();
            this.rmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridmhs
            // 
            this.gridmhs.AllowUserToAddRows = false;
            this.gridmhs.AllowUserToDeleteRows = false;
            this.gridmhs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridmhs.AutoGenerateColumns = false;
            this.gridmhs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmhs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridmhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._numcolumn,
            this.nimDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.angkatanDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn,
            this.jurusanDataGridViewTextBoxColumn,
            this.fakultasDataGridViewTextBoxColumn,
            this.auxDataGridViewTextBoxColumn});
            this.gridmhs.DataSource = this.msmhsBindingSource;
            this.gridmhs.Location = new System.Drawing.Point(12, 41);
            this.gridmhs.Name = "gridmhs";
            this.gridmhs.ReadOnly = true;
            this.gridmhs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridmhs.RowHeadersVisible = false;
            this.gridmhs.Size = new System.Drawing.Size(803, 336);
            this.gridmhs.TabIndex = 0;
            this.gridmhs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.gridmhs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridmhs_MouseDown);
            // 
            // _numcolumn
            // 
            this._numcolumn.FillWeight = 60F;
            this._numcolumn.HeaderText = "No";
            this._numcolumn.Name = "_numcolumn";
            this._numcolumn.ReadOnly = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angkatanDataGridViewTextBoxColumn
            // 
            this.angkatanDataGridViewTextBoxColumn.DataPropertyName = "angkatan";
            this.angkatanDataGridViewTextBoxColumn.HeaderText = "Angkatan";
            this.angkatanDataGridViewTextBoxColumn.Name = "angkatanDataGridViewTextBoxColumn";
            this.angkatanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodiDataGridViewTextBoxColumn
            // 
            this.prodiDataGridViewTextBoxColumn.DataPropertyName = "prodi";
            this.prodiDataGridViewTextBoxColumn.HeaderText = "Program Studi";
            this.prodiDataGridViewTextBoxColumn.Name = "prodiDataGridViewTextBoxColumn";
            this.prodiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurusanDataGridViewTextBoxColumn
            // 
            this.jurusanDataGridViewTextBoxColumn.DataPropertyName = "jurusan";
            this.jurusanDataGridViewTextBoxColumn.HeaderText = "Jurusan";
            this.jurusanDataGridViewTextBoxColumn.Name = "jurusanDataGridViewTextBoxColumn";
            this.jurusanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fakultasDataGridViewTextBoxColumn
            // 
            this.fakultasDataGridViewTextBoxColumn.DataPropertyName = "fakultas";
            this.fakultasDataGridViewTextBoxColumn.HeaderText = "Fakultas";
            this.fakultasDataGridViewTextBoxColumn.Name = "fakultasDataGridViewTextBoxColumn";
            this.fakultasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auxDataGridViewTextBoxColumn
            // 
            this.auxDataGridViewTextBoxColumn.DataPropertyName = "aux";
            this.auxDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.auxDataGridViewTextBoxColumn.Name = "auxDataGridViewTextBoxColumn";
            this.auxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msmhsBindingSource
            // 
            this.msmhsBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.ms_mhs);
            // 
            // btnew
            // 
            this.btnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnew.Location = new System.Drawing.Point(721, 3);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(94, 32);
            this.btnew.TabIndex = 1;
            this.btnew.Text = "New";
            this.btnew.UseVisualStyleBackColor = true;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
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
            this.bfilter.Location = new System.Drawing.Point(55, 14);
            this.bfilter.Name = "bfilter";
            this.bfilter.Size = new System.Drawing.Size(203, 20);
            this.bfilter.TabIndex = 3;
            this.bfilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bfilter_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // FormDataMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(827, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bfilter);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.gridmhs);
            this.Name = "FormDataMhs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.FormDataMhs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridmhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).EndInit();
            this.rmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridmhs;
        private System.Windows.Forms.BindingSource msmhsBindingSource;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.ContextMenuStrip rmenu;
        private System.Windows.Forms.ToolStripMenuItem ubahDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auxDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox bfilter;
        private System.Windows.Forms.Label label1;
    }
}