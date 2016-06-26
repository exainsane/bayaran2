namespace Bayaran_2._0.Forms
{
    partial class Importer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lpr1 = new System.Windows.Forms.Label();
            this.lpr2 = new System.Windows.Forms.Label();
            this.lpr3 = new System.Windows.Forms.Label();
            this.lpr4 = new System.Windows.Forms.Label();
            this.p_selectfile = new System.Windows.Forms.Panel();
            this.panel_loader = new System.Windows.Forms.Panel();
            this.read_loader = new MRG.Controls.UI.LoadingCircle();
            this.label11 = new System.Windows.Forms.Label();
            this.b_usefile = new System.Windows.Forms.Button();
            this.cb_containheader = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_previewfile = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_openfileselect = new System.Windows.Forms.Button();
            this.t_filename = new System.Windows.Forms.TextBox();
            this.p_final_progress = new System.Windows.Forms.Panel();
            this.b_end_close = new System.Windows.Forms.Button();
            this.l_status = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.prg_import = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p_checkcolumn = new System.Windows.Forms.Panel();
            this.b_cancelimport = new System.Windows.Forms.Button();
            this.b_startimport = new System.Windows.Forms.Button();
            this.dg_checkcolumn = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_overview = new System.Windows.Forms.Panel();
            this.blanjutkan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.loader_checkcolumn = new System.Windows.Forms.Panel();
            this.loadingCircle1 = new MRG.Controls.UI.LoadingCircle();
            this.label13 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.p_selectfile.SuspendLayout();
            this.panel_loader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_previewfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.p_final_progress.SuspendLayout();
            this.p_checkcolumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_checkcolumn)).BeginInit();
            this.p_overview.SuspendLayout();
            this.loader_checkcolumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.p_checkcolumn);
            this.splitContainer1.Panel2.Controls.Add(this.p_selectfile);
            this.splitContainer1.Panel2.Controls.Add(this.p_final_progress);
            this.splitContainer1.Panel2.Controls.Add(this.p_overview);
            this.splitContainer1.Size = new System.Drawing.Size(999, 455);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lpr1);
            this.flowLayoutPanel1.Controls.Add(this.lpr2);
            this.flowLayoutPanel1.Controls.Add(this.lpr3);
            this.flowLayoutPanel1.Controls.Add(this.lpr4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 431);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lpr1
            // 
            this.lpr1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lpr1.Location = new System.Drawing.Point(5, 5);
            this.lpr1.Margin = new System.Windows.Forms.Padding(5);
            this.lpr1.Name = "lpr1";
            this.lpr1.Size = new System.Drawing.Size(175, 23);
            this.lpr1.TabIndex = 0;
            this.lpr1.Text = "Overview";
            this.lpr1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lpr2
            // 
            this.lpr2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lpr2.Location = new System.Drawing.Point(5, 38);
            this.lpr2.Margin = new System.Windows.Forms.Padding(5);
            this.lpr2.Name = "lpr2";
            this.lpr2.Size = new System.Drawing.Size(175, 23);
            this.lpr2.TabIndex = 0;
            this.lpr2.Text = "Pilih file xls";
            this.lpr2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lpr3
            // 
            this.lpr3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lpr3.Location = new System.Drawing.Point(5, 71);
            this.lpr3.Margin = new System.Windows.Forms.Padding(5);
            this.lpr3.Name = "lpr3";
            this.lpr3.Size = new System.Drawing.Size(175, 23);
            this.lpr3.TabIndex = 0;
            this.lpr3.Text = "Cek kolom data";
            this.lpr3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lpr4
            // 
            this.lpr4.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lpr4.Location = new System.Drawing.Point(5, 104);
            this.lpr4.Margin = new System.Windows.Forms.Padding(5);
            this.lpr4.Name = "lpr4";
            this.lpr4.Size = new System.Drawing.Size(175, 23);
            this.lpr4.TabIndex = 0;
            this.lpr4.Text = "Proses import";
            this.lpr4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p_selectfile
            // 
            this.p_selectfile.Controls.Add(this.panel_loader);
            this.p_selectfile.Controls.Add(this.b_usefile);
            this.p_selectfile.Controls.Add(this.cb_containheader);
            this.p_selectfile.Controls.Add(this.label2);
            this.p_selectfile.Controls.Add(this.label12);
            this.p_selectfile.Controls.Add(this.label1);
            this.p_selectfile.Controls.Add(this.dg_previewfile);
            this.p_selectfile.Controls.Add(this.groupBox1);
            this.p_selectfile.Location = new System.Drawing.Point(20, 106);
            this.p_selectfile.Name = "p_selectfile";
            this.p_selectfile.Size = new System.Drawing.Size(318, 225);
            this.p_selectfile.TabIndex = 1;
            this.p_selectfile.Visible = false;
            // 
            // panel_loader
            // 
            this.panel_loader.Controls.Add(this.read_loader);
            this.panel_loader.Controls.Add(this.label11);
            this.panel_loader.Location = new System.Drawing.Point(509, 19);
            this.panel_loader.Name = "panel_loader";
            this.panel_loader.Size = new System.Drawing.Size(155, 42);
            this.panel_loader.TabIndex = 5;
            this.panel_loader.Visible = false;
            // 
            // read_loader
            // 
            this.read_loader.Active = true;
            this.read_loader.Color = System.Drawing.Color.DarkGray;
            this.read_loader.InnerCircleRadius = 8;
            this.read_loader.Location = new System.Drawing.Point(10, 2);
            this.read_loader.Name = "read_loader";
            this.read_loader.NumberSpoke = 24;
            this.read_loader.OuterCircleRadius = 9;
            this.read_loader.RotationSpeed = 100;
            this.read_loader.Size = new System.Drawing.Size(52, 39);
            this.read_loader.SpokeThickness = 4;
            this.read_loader.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7;
            this.read_loader.TabIndex = 12;
            this.read_loader.Text = "Loading...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label11.Location = new System.Drawing.Point(64, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Membaca file";
            // 
            // b_usefile
            // 
            this.b_usefile.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.b_usefile.Location = new System.Drawing.Point(600, 407);
            this.b_usefile.Name = "b_usefile";
            this.b_usefile.Size = new System.Drawing.Size(152, 36);
            this.b_usefile.TabIndex = 4;
            this.b_usefile.Text = "Gunakan file ini";
            this.b_usefile.UseVisualStyleBackColor = true;
            // 
            // cb_containheader
            // 
            this.cb_containheader.AutoSize = true;
            this.cb_containheader.Checked = true;
            this.cb_containheader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_containheader.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.cb_containheader.Location = new System.Drawing.Point(509, 91);
            this.cb_containheader.Name = "cb_containheader";
            this.cb_containheader.Size = new System.Drawing.Size(244, 19);
            this.cb_containheader.TabIndex = 3;
            this.cb_containheader.Text = "Baris pertama file adalah header kolom";
            this.cb_containheader.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label2.Location = new System.Drawing.Point(17, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cek apakah file yang di import berisi data yang benar, lalu klik \"Gunakan file in" +
    "i\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview";
            // 
            // dg_previewfile
            // 
            this.dg_previewfile.AllowUserToAddRows = false;
            this.dg_previewfile.AllowUserToDeleteRows = false;
            this.dg_previewfile.AllowUserToOrderColumns = true;
            this.dg_previewfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_previewfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_previewfile.Location = new System.Drawing.Point(17, 116);
            this.dg_previewfile.Name = "dg_previewfile";
            this.dg_previewfile.RowHeadersVisible = false;
            this.dg_previewfile.Size = new System.Drawing.Size(736, 284);
            this.dg_previewfile.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_openfileselect);
            this.groupBox1.Controls.Add(this.t_filename);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih file";
            // 
            // b_openfileselect
            // 
            this.b_openfileselect.Location = new System.Drawing.Point(401, 22);
            this.b_openfileselect.Name = "b_openfileselect";
            this.b_openfileselect.Size = new System.Drawing.Size(75, 23);
            this.b_openfileselect.TabIndex = 1;
            this.b_openfileselect.Text = "Pilih";
            this.b_openfileselect.UseVisualStyleBackColor = true;
            // 
            // t_filename
            // 
            this.t_filename.Location = new System.Drawing.Point(6, 22);
            this.t_filename.Name = "t_filename";
            this.t_filename.ReadOnly = true;
            this.t_filename.Size = new System.Drawing.Size(388, 23);
            this.t_filename.TabIndex = 0;
            // 
            // p_final_progress
            // 
            this.p_final_progress.Controls.Add(this.b_end_close);
            this.p_final_progress.Controls.Add(this.l_status);
            this.p_final_progress.Controls.Add(this.label10);
            this.p_final_progress.Controls.Add(this.prg_import);
            this.p_final_progress.Controls.Add(this.label9);
            this.p_final_progress.Controls.Add(this.label8);
            this.p_final_progress.Location = new System.Drawing.Point(63, 139);
            this.p_final_progress.Name = "p_final_progress";
            this.p_final_progress.Size = new System.Drawing.Size(537, 286);
            this.p_final_progress.TabIndex = 3;
            // 
            // b_end_close
            // 
            this.b_end_close.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.b_end_close.Location = new System.Drawing.Point(579, 293);
            this.b_end_close.Name = "b_end_close";
            this.b_end_close.Size = new System.Drawing.Size(155, 44);
            this.b_end_close.TabIndex = 3;
            this.b_end_close.Text = "Tutup";
            this.b_end_close.UseVisualStyleBackColor = true;
            this.b_end_close.Visible = false;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.l_status.Location = new System.Drawing.Point(67, 167);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(11, 15);
            this.l_status.TabIndex = 2;
            this.l_status.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label10.Location = new System.Drawing.Point(16, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Status : ";
            // 
            // prg_import
            // 
            this.prg_import.Location = new System.Drawing.Point(19, 185);
            this.prg_import.Name = "prg_import";
            this.prg_import.Size = new System.Drawing.Size(716, 23);
            this.prg_import.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label9.Location = new System.Drawing.Point(16, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(593, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Proses input data akan memakan waktu beberapa saat tergantung kekuatan komputer d" +
    "an banyaknya data\r\nSilahkan tunggu hingga proses ini selesai\r\n";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Proses input data";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // p_checkcolumn
            // 
            this.p_checkcolumn.Controls.Add(this.loader_checkcolumn);
            this.p_checkcolumn.Controls.Add(this.b_cancelimport);
            this.p_checkcolumn.Controls.Add(this.b_startimport);
            this.p_checkcolumn.Controls.Add(this.dg_checkcolumn);
            this.p_checkcolumn.Controls.Add(this.label7);
            this.p_checkcolumn.Controls.Add(this.label4);
            this.p_checkcolumn.Controls.Add(this.label3);
            this.p_checkcolumn.Location = new System.Drawing.Point(3, 62);
            this.p_checkcolumn.Name = "p_checkcolumn";
            this.p_checkcolumn.Size = new System.Drawing.Size(768, 328);
            this.p_checkcolumn.TabIndex = 2;
            this.p_checkcolumn.Visible = false;
            // 
            // b_cancelimport
            // 
            this.b_cancelimport.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.b_cancelimport.Location = new System.Drawing.Point(328, 411);
            this.b_cancelimport.Name = "b_cancelimport";
            this.b_cancelimport.Size = new System.Drawing.Size(238, 29);
            this.b_cancelimport.TabIndex = 2;
            this.b_cancelimport.Text = "Tidak, ulangi prosedur import";
            this.b_cancelimport.UseVisualStyleBackColor = true;
            // 
            // b_startimport
            // 
            this.b_startimport.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.b_startimport.Location = new System.Drawing.Point(582, 411);
            this.b_startimport.Name = "b_startimport";
            this.b_startimport.Size = new System.Drawing.Size(184, 29);
            this.b_startimport.TabIndex = 2;
            this.b_startimport.Text = "Ya, mulai proses import";
            this.b_startimport.UseVisualStyleBackColor = true;
            // 
            // dg_checkcolumn
            // 
            this.dg_checkcolumn.AllowUserToAddRows = false;
            this.dg_checkcolumn.AllowUserToDeleteRows = false;
            this.dg_checkcolumn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_checkcolumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_checkcolumn.Location = new System.Drawing.Point(8, 65);
            this.dg_checkcolumn.Name = "dg_checkcolumn";
            this.dg_checkcolumn.RowHeadersVisible = false;
            this.dg_checkcolumn.Size = new System.Drawing.Size(759, 339);
            this.dg_checkcolumn.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label7.Location = new System.Drawing.Point(5, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Apakah data sudah sesuai?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label4.Location = new System.Drawing.Point(5, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kolom yang ada pada file xls mungkin berbeda dengan susunan kolom yang digunakan " +
    "program\r\nApabila ada ketidaksesuaian kolom, silahkan ubah posisi kolom didalam f" +
    "ile xls dan ulangi proses import";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cek kolom data";
            // 
            // p_overview
            // 
            this.p_overview.Controls.Add(this.blanjutkan);
            this.p_overview.Controls.Add(this.label6);
            this.p_overview.Controls.Add(this.label5);
            this.p_overview.Location = new System.Drawing.Point(3, 3);
            this.p_overview.Name = "p_overview";
            this.p_overview.Size = new System.Drawing.Size(67, 53);
            this.p_overview.TabIndex = 0;
            this.p_overview.Visible = false;
            // 
            // blanjutkan
            // 
            this.blanjutkan.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.blanjutkan.Location = new System.Drawing.Point(576, 325);
            this.blanjutkan.Name = "blanjutkan";
            this.blanjutkan.Size = new System.Drawing.Size(177, 31);
            this.blanjutkan.TabIndex = 2;
            this.blanjutkan.Text = "Lanjutkan";
            this.blanjutkan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(736, 176);
            this.label6.TabIndex = 1;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Import data mahasiswa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Underline);
            this.label12.Location = new System.Drawing.Point(455, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Refresh";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // loader_checkcolumn
            // 
            this.loader_checkcolumn.Controls.Add(this.loadingCircle1);
            this.loader_checkcolumn.Controls.Add(this.label13);
            this.loader_checkcolumn.Location = new System.Drawing.Point(610, 17);
            this.loader_checkcolumn.Name = "loader_checkcolumn";
            this.loader_checkcolumn.Size = new System.Drawing.Size(155, 42);
            this.loader_checkcolumn.TabIndex = 6;
            this.loader_checkcolumn.Visible = false;
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Active = true;
            this.loadingCircle1.Color = System.Drawing.Color.DarkGray;
            this.loadingCircle1.InnerCircleRadius = 8;
            this.loadingCircle1.Location = new System.Drawing.Point(10, 2);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.NumberSpoke = 24;
            this.loadingCircle1.OuterCircleRadius = 9;
            this.loadingCircle1.RotationSpeed = 100;
            this.loadingCircle1.Size = new System.Drawing.Size(52, 39);
            this.loadingCircle1.SpokeThickness = 4;
            this.loadingCircle1.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7;
            this.loadingCircle1.TabIndex = 12;
            this.loadingCircle1.Text = "Loading...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.label13.Location = new System.Drawing.Point(64, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Membaca file";
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 455);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Importer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importer";
            this.Load += new System.EventHandler(this.Importer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.p_selectfile.ResumeLayout(false);
            this.p_selectfile.PerformLayout();
            this.panel_loader.ResumeLayout(false);
            this.panel_loader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_previewfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.p_final_progress.ResumeLayout(false);
            this.p_final_progress.PerformLayout();
            this.p_checkcolumn.ResumeLayout(false);
            this.p_checkcolumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_checkcolumn)).EndInit();
            this.p_overview.ResumeLayout(false);
            this.p_overview.PerformLayout();
            this.loader_checkcolumn.ResumeLayout(false);
            this.loader_checkcolumn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lpr1;
        private System.Windows.Forms.Label lpr2;
        private System.Windows.Forms.Label lpr3;
        private System.Windows.Forms.Label lpr4;
        private System.Windows.Forms.Panel p_overview;
        private System.Windows.Forms.Button blanjutkan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel p_selectfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_previewfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_openfileselect;
        private System.Windows.Forms.TextBox t_filename;
        private System.Windows.Forms.CheckBox cb_containheader;
        private System.Windows.Forms.Button b_usefile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p_checkcolumn;
        private System.Windows.Forms.Button b_cancelimport;
        private System.Windows.Forms.Button b_startimport;
        private System.Windows.Forms.DataGridView dg_checkcolumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel p_final_progress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar prg_import;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_end_close;
        private System.Windows.Forms.Panel panel_loader;
        private MRG.Controls.UI.LoadingCircle read_loader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel loader_checkcolumn;
        private MRG.Controls.UI.LoadingCircle loadingCircle1;
        private System.Windows.Forms.Label label13;
    }
}