namespace Bayaran_2._0.Forms
{
    partial class FormAssignGolongan
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
            this.gridassigngol = new System.Windows.Forms.DataGridView();
            this._numcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagolonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwassigngolonganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asmhsgolonganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bassign = new System.Windows.Forms.Button();
            this.bbatchassign = new System.Windows.Forms.Button();
            this.bfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ubahDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridassigngol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwassigngolonganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmhsgolonganBindingSource)).BeginInit();
            this.rmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridassigngol
            // 
            this.gridassigngol.AllowUserToAddRows = false;
            this.gridassigngol.AllowUserToDeleteRows = false;
            this.gridassigngol.AutoGenerateColumns = false;
            this.gridassigngol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridassigngol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridassigngol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._numcolumn,
            this.datagolonganDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.nimDataGridViewTextBoxColumn,
            this.angkatanDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn,
            this.jurusanDataGridViewTextBoxColumn,
            this.fakultasDataGridViewTextBoxColumn,
            this.auxDataGridViewTextBoxColumn});
            this.gridassigngol.DataSource = this.vwassigngolonganBindingSource;
            this.gridassigngol.Location = new System.Drawing.Point(13, 47);
            this.gridassigngol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridassigngol.Name = "gridassigngol";
            this.gridassigngol.ReadOnly = true;
            this.gridassigngol.RowHeadersVisible = false;
            this.gridassigngol.Size = new System.Drawing.Size(838, 323);
            this.gridassigngol.TabIndex = 0;
            this.gridassigngol.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.gridassigngol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridmhs_MouseDown);
            // 
            // _numcolumn
            // 
            this._numcolumn.FillWeight = 35F;
            this._numcolumn.HeaderText = "No";
            this._numcolumn.Name = "_numcolumn";
            this._numcolumn.ReadOnly = true;
            // 
            // datagolonganDataGridViewTextBoxColumn
            // 
            this.datagolonganDataGridViewTextBoxColumn.DataPropertyName = "data_golongan";
            this.datagolonganDataGridViewTextBoxColumn.HeaderText = "Golongan";
            this.datagolonganDataGridViewTextBoxColumn.Name = "datagolonganDataGridViewTextBoxColumn";
            this.datagolonganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.prodiDataGridViewTextBoxColumn.HeaderText = "Prodi";
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
            this.auxDataGridViewTextBoxColumn.HeaderText = "Ket.";
            this.auxDataGridViewTextBoxColumn.Name = "auxDataGridViewTextBoxColumn";
            this.auxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwassigngolonganBindingSource
            // 
            this.vwassigngolonganBindingSource.DataSource = typeof(Bayaran_2._0.Controller.ControllerAssignGolongan.vw_assign_golongan);
            // 
            // asmhsgolonganBindingSource
            // 
            this.asmhsgolonganBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.as_mhs_golongan);
            // 
            // bassign
            // 
            this.bassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bassign.Location = new System.Drawing.Point(737, 11);
            this.bassign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bassign.Name = "bassign";
            this.bassign.Size = new System.Drawing.Size(114, 29);
            this.bassign.TabIndex = 1;
            this.bassign.Text = "Assign";
            this.bassign.UseVisualStyleBackColor = true;
            this.bassign.Click += new System.EventHandler(this.btnew_Click);
            // 
            // bbatchassign
            // 
            this.bbatchassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbatchassign.Location = new System.Drawing.Point(617, 11);
            this.bbatchassign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bbatchassign.Name = "bbatchassign";
            this.bbatchassign.Size = new System.Drawing.Size(114, 29);
            this.bbatchassign.TabIndex = 1;
            this.bbatchassign.Text = "Batch Assign";
            this.bbatchassign.UseVisualStyleBackColor = true;
            this.bbatchassign.Click += new System.EventHandler(this.button2_Click);
            // 
            // bfilter
            // 
            this.bfilter.Location = new System.Drawing.Point(55, 13);
            this.bfilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bfilter.Name = "bfilter";
            this.bfilter.Size = new System.Drawing.Size(227, 20);
            this.bfilter.TabIndex = 2;
            this.bfilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bfilter_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_mhs";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mahasiswa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 327;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "golongan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Golongan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 326;
            // 
            // FormAssignGolongan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(863, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bfilter);
            this.Controls.Add(this.bbatchassign);
            this.Controls.Add(this.bassign);
            this.Controls.Add(this.gridassigngol);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormAssignGolongan";
            this.Text = "FormAssignGolongan";
            this.Load += new System.EventHandler(this.FormAssignGolongan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridassigngol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwassigngolonganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmhsgolonganBindingSource)).EndInit();
            this.rmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridassigngol;
        private System.Windows.Forms.Button bassign;
        private System.Windows.Forms.Button bbatchassign;
        private System.Windows.Forms.TextBox bfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource asmhsgolonganBindingSource;
        private System.Windows.Forms.ContextMenuStrip rmenu;
        private System.Windows.Forms.ToolStripMenuItem ubahDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagolonganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwassigngolonganBindingSource;
    }
}