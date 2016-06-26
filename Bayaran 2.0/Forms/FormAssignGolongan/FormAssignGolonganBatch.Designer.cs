namespace Bayaran_2._0.Forms
{
    partial class FormAssignGolonganBatch
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cangkatan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cgol = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._numcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bassign = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.bapplybatch = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cangkatan);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angkatan";
            // 
            // cangkatan
            // 
            this.cangkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cangkatan.FormattingEnabled = true;
            this.cangkatan.Location = new System.Drawing.Point(3, 19);
            this.cangkatan.Name = "cangkatan";
            this.cangkatan.Size = new System.Drawing.Size(240, 21);
            this.cangkatan.TabIndex = 0;
            this.cangkatan.SelectedIndexChanged += new System.EventHandler(this.cangkatan_SelectedIndexChanged);
            this.cangkatan.DataSourceChanged += new System.EventHandler(this.cangkatan_DataSourceChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cgol);
            this.groupBox1.Location = new System.Drawing.Point(615, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masuk ke golongan";
            // 
            // cgol
            // 
            this.cgol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cgol.FormattingEnabled = true;
            this.cgol.Location = new System.Drawing.Point(3, 19);
            this.cgol.Name = "cgol";
            this.cgol.Size = new System.Drawing.Size(240, 21);
            this.cgol.TabIndex = 0;
            this.cgol.SelectedIndexChanged += new System.EventHandler(this.cgol_SelectedIndexChanged);
            this.cgol.DataSourceChanged += new System.EventHandler(this.cangkatan_DataSourceChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Location = new System.Drawing.Point(618, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 152);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detil golongan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 133);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 28);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label14.Location = new System.Drawing.Point(131, 2);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label14.Size = new System.Drawing.Size(78, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "5235153384";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label15.Location = new System.Drawing.Point(-1, 2);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label15.Size = new System.Drawing.Size(126, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "NIM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 28);
            this.panel2.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label16.Location = new System.Drawing.Point(60, 2);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label16.Size = new System.Drawing.Size(149, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "5235153384";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label17.Location = new System.Drawing.Point(-1, 2);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label17.Size = new System.Drawing.Size(29, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "NIM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(3, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 28);
            this.panel3.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label18.Location = new System.Drawing.Point(60, 2);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label18.Size = new System.Drawing.Size(149, 23);
            this.label18.TabIndex = 1;
            this.label18.Text = "5235153384";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label19.Location = new System.Drawing.Point(-1, 2);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label19.Size = new System.Drawing.Size(29, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "NIM";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(3, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 28);
            this.panel4.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label20.Location = new System.Drawing.Point(60, 2);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label20.Size = new System.Drawing.Size(149, 23);
            this.label20.TabIndex = 1;
            this.label20.Text = "5235153384";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label21.Location = new System.Drawing.Point(-1, 2);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label21.Size = new System.Drawing.Size(29, 24);
            this.label21.TabIndex = 2;
            this.label21.Text = "NIM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._numcolumn,
            this.namaDataGridViewTextBoxColumn,
            this.nimDataGridViewTextBoxColumn,
            this.angkatanDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn,
            this.jurusanDataGridViewTextBoxColumn,
            this.fakultasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.msmhsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(600, 245);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // _numcolumn
            // 
            this._numcolumn.FillWeight = 35F;
            this._numcolumn.HeaderText = "No";
            this._numcolumn.Name = "_numcolumn";
            this._numcolumn.ReadOnly = true;
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
            // msmhsBindingSource
            // 
            this.msmhsBindingSource.DataSource = typeof(Bayaran_2._0.Model.DataStructure.ms_mhs);
            // 
            // bassign
            // 
            this.bassign.Location = new System.Drawing.Point(756, 273);
            this.bassign.Name = "bassign";
            this.bassign.Size = new System.Drawing.Size(108, 39);
            this.bassign.TabIndex = 11;
            this.bassign.Text = "Assign";
            this.bassign.UseVisualStyleBackColor = true;
            this.bassign.Click += new System.EventHandler(this.bassign_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(640, 273);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(108, 39);
            this.bcancel.TabIndex = 11;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // bapplybatch
            // 
            this.bapplybatch.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.bapplybatch.Location = new System.Drawing.Point(637, 247);
            this.bapplybatch.Name = "bapplybatch";
            this.bapplybatch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.bapplybatch.Size = new System.Drawing.Size(230, 23);
            this.bapplybatch.TabIndex = 12;
            this.bapplybatch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormAssignGolonganBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(876, 324);
            this.Controls.Add(this.bapplybatch);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bassign);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAssignGolonganBatch";
            this.Text = "FormAssignGolonganBatch";
            this.Load += new System.EventHandler(this.FormAssignGolonganBatch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cangkatan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cgol;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource msmhsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bassign;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Label bapplybatch;
    }
}