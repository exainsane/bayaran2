namespace Bayaran_2._0.Forms
{
    partial class FormAssignGolonganCRUD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_errornim = new System.Windows.Forms.Label();
            this.tbnim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cgol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_angkatan = new System.Windows.Forms.Label();
            this.l_prodi = new System.Windows.Forms.Label();
            this.l_jurusan = new System.Windows.Forms.Label();
            this.l_nama = new System.Windows.Forms.Label();
            this.l_nim = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.bassign = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_errornim);
            this.groupBox1.Controls.Add(this.tbnim);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input NIM";
            // 
            // l_errornim
            // 
            this.l_errornim.Location = new System.Drawing.Point(3, 37);
            this.l_errornim.Name = "l_errornim";
            this.l_errornim.Size = new System.Drawing.Size(218, 23);
            this.l_errornim.TabIndex = 1;
            this.l_errornim.Text = "Data tidak ditemukan!";
            this.l_errornim.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbnim
            // 
            this.tbnim.Location = new System.Drawing.Point(3, 16);
            this.tbnim.Name = "tbnim";
            this.tbnim.Size = new System.Drawing.Size(218, 20);
            this.tbnim.TabIndex = 0;
            this.tbnim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnim_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cgol);
            this.groupBox2.Location = new System.Drawing.Point(246, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masuk ke golongan";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harap input NIM terlebih dahulu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.cgol.DataSourceChanged += new System.EventHandler(this.cgol_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Golongan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.l_angkatan);
            this.groupBox3.Controls.Add(this.l_prodi);
            this.groupBox3.Controls.Add(this.l_jurusan);
            this.groupBox3.Controls.Add(this.l_nama);
            this.groupBox3.Controls.Add(this.l_nim);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 152);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biodata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angkatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jurusan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nama";
            // 
            // l_angkatan
            // 
            this.l_angkatan.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.l_angkatan.Location = new System.Drawing.Point(68, 112);
            this.l_angkatan.Name = "l_angkatan";
            this.l_angkatan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.l_angkatan.Size = new System.Drawing.Size(153, 23);
            this.l_angkatan.TabIndex = 0;
            this.l_angkatan.Text = "2015";
            // 
            // l_prodi
            // 
            this.l_prodi.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.l_prodi.Location = new System.Drawing.Point(68, 89);
            this.l_prodi.Name = "l_prodi";
            this.l_prodi.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.l_prodi.Size = new System.Drawing.Size(153, 24);
            this.l_prodi.TabIndex = 0;
            this.l_prodi.Text = "Pendidikan Teknik Informatika dan Komputer";
            // 
            // l_jurusan
            // 
            this.l_jurusan.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.l_jurusan.Location = new System.Drawing.Point(68, 66);
            this.l_jurusan.Name = "l_jurusan";
            this.l_jurusan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.l_jurusan.Size = new System.Drawing.Size(153, 23);
            this.l_jurusan.TabIndex = 0;
            this.l_jurusan.Text = "Teknik Elektro";
            // 
            // l_nama
            // 
            this.l_nama.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.l_nama.Location = new System.Drawing.Point(68, 43);
            this.l_nama.Name = "l_nama";
            this.l_nama.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.l_nama.Size = new System.Drawing.Size(153, 23);
            this.l_nama.TabIndex = 0;
            this.l_nama.Text = "Ridwan Achadi Nugroho";
            // 
            // l_nim
            // 
            this.l_nim.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.l_nim.Location = new System.Drawing.Point(68, 20);
            this.l_nim.Name = "l_nim";
            this.l_nim.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.l_nim.Size = new System.Drawing.Size(153, 23);
            this.l_nim.TabIndex = 0;
            this.l_nim.Text = "5235153384";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label13.Size = new System.Drawing.Size(29, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "NIM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Location = new System.Drawing.Point(246, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 152);
            this.groupBox4.TabIndex = 8;
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
            // bassign
            // 
            this.bassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bassign.Location = new System.Drawing.Point(412, 273);
            this.bassign.Name = "bassign";
            this.bassign.Size = new System.Drawing.Size(82, 26);
            this.bassign.TabIndex = 9;
            this.bassign.Text = "Assign";
            this.bassign.UseVisualStyleBackColor = true;
            this.bassign.Click += new System.EventHandler(this.bassign_Click);
            // 
            // bcancel
            // 
            this.bcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bcancel.Location = new System.Drawing.Point(324, 273);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(82, 26);
            this.bcancel.TabIndex = 9;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAssignGolonganCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(507, 311);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bassign);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAssignGolonganCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Golongan";
            this.Load += new System.EventHandler(this.FormAssignGolonganCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_errornim;
        private System.Windows.Forms.TextBox tbnim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cgol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_angkatan;
        private System.Windows.Forms.Label l_prodi;
        private System.Windows.Forms.Label l_jurusan;
        private System.Windows.Forms.Label l_nama;
        private System.Windows.Forms.Label l_nim;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.Button bassign;
        private System.Windows.Forms.Button bcancel;
    }
}