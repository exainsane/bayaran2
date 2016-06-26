namespace Bayaran_2._0.Forms
{
    partial class FormNominalKhususCRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.angkatan = new System.Windows.Forms.Label();
            this.prodi = new System.Windows.Forms.Label();
            this.jurusan = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lgolongan = new System.Windows.Forms.Label();
            this.lnominal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.beasiswano = new System.Windows.Forms.RadioButton();
            this.beasiswayes = new System.Windows.Forms.RadioButton();
            this.nominal = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.bsimpan = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal Khusus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbnim);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input NIM";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data tidak ditemukan!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbnim
            // 
            this.tbnim.Location = new System.Drawing.Point(7, 20);
            this.tbnim.Name = "tbnim";
            this.tbnim.Size = new System.Drawing.Size(214, 20);
            this.tbnim.TabIndex = 0;
            this.tbnim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnim_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbtrans);
            this.groupBox2.Location = new System.Drawing.Point(246, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jenis transaksi yang diubah";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harap input NIM terlebih dahulu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbtrans
            // 
            this.cbtrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtrans.FormattingEnabled = true;
            this.cbtrans.Location = new System.Drawing.Point(7, 20);
            this.cbtrans.Name = "cbtrans";
            this.cbtrans.Size = new System.Drawing.Size(276, 21);
            this.cbtrans.TabIndex = 1;
            this.cbtrans.SelectedIndexChanged += new System.EventHandler(this.cbtrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.angkatan);
            this.groupBox3.Controls.Add(this.prodi);
            this.groupBox3.Controls.Add(this.jurusan);
            this.groupBox3.Controls.Add(this.nama);
            this.groupBox3.Controls.Add(this.nim);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
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
            // angkatan
            // 
            this.angkatan.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.angkatan.Location = new System.Drawing.Point(68, 112);
            this.angkatan.Name = "angkatan";
            this.angkatan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.angkatan.Size = new System.Drawing.Size(153, 23);
            this.angkatan.TabIndex = 0;
            this.angkatan.Text = "2015";
            // 
            // prodi
            // 
            this.prodi.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.prodi.Location = new System.Drawing.Point(68, 89);
            this.prodi.Name = "prodi";
            this.prodi.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.prodi.Size = new System.Drawing.Size(153, 24);
            this.prodi.TabIndex = 0;
            this.prodi.Text = "Pendidikan Teknik Informatika dan Komputer";
            // 
            // jurusan
            // 
            this.jurusan.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.jurusan.Location = new System.Drawing.Point(68, 66);
            this.jurusan.Name = "jurusan";
            this.jurusan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.jurusan.Size = new System.Drawing.Size(153, 23);
            this.jurusan.TabIndex = 0;
            this.jurusan.Text = "Teknik Elektro";
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.nama.Location = new System.Drawing.Point(68, 43);
            this.nama.Name = "nama";
            this.nama.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.nama.Size = new System.Drawing.Size(153, 23);
            this.nama.TabIndex = 0;
            this.nama.Text = "Ridwan Achadi Nugroho";
            // 
            // nim
            // 
            this.nim.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.nim.Location = new System.Drawing.Point(68, 20);
            this.nim.Name = "nim";
            this.nim.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.nim.Size = new System.Drawing.Size(153, 23);
            this.nim.TabIndex = 0;
            this.nim.Text = "5235153384";
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
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lgolongan);
            this.groupBox4.Controls.Add(this.lnominal);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.groupBox4.Location = new System.Drawing.Point(246, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 89);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detil jenis transaksi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label17.Location = new System.Drawing.Point(7, 43);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label17.Size = new System.Drawing.Size(60, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Golongan";
            // 
            // lgolongan
            // 
            this.lgolongan.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgolongan.Location = new System.Drawing.Point(82, 43);
            this.lgolongan.Name = "lgolongan";
            this.lgolongan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lgolongan.Size = new System.Drawing.Size(324, 23);
            this.lgolongan.TabIndex = 0;
            this.lgolongan.Text = "3";
            // 
            // lnominal
            // 
            this.lnominal.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.lnominal.Location = new System.Drawing.Point(82, 20);
            this.lnominal.Name = "lnominal";
            this.lnominal.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lnominal.Size = new System.Drawing.Size(324, 23);
            this.lnominal.TabIndex = 0;
            this.lnominal.Text = "Rp 150.000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label23.Location = new System.Drawing.Point(7, 20);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label23.Size = new System.Drawing.Size(54, 24);
            this.label23.TabIndex = 0;
            this.label23.Text = "Nominal";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.beasiswano);
            this.groupBox5.Controls.Add(this.beasiswayes);
            this.groupBox5.Controls.Add(this.nominal);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.groupBox5.Location = new System.Drawing.Point(253, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 82);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Override value";
            // 
            // beasiswano
            // 
            this.beasiswano.AutoSize = true;
            this.beasiswano.Checked = true;
            this.beasiswano.Location = new System.Drawing.Point(129, 52);
            this.beasiswano.Name = "beasiswano";
            this.beasiswano.Size = new System.Drawing.Size(55, 18);
            this.beasiswano.TabIndex = 6;
            this.beasiswano.TabStop = true;
            this.beasiswano.Text = "Tidak";
            this.beasiswano.UseVisualStyleBackColor = true;
            // 
            // beasiswayes
            // 
            this.beasiswayes.AutoSize = true;
            this.beasiswayes.Location = new System.Drawing.Point(86, 52);
            this.beasiswayes.Name = "beasiswayes";
            this.beasiswayes.Size = new System.Drawing.Size(37, 18);
            this.beasiswayes.TabIndex = 6;
            this.beasiswayes.Text = "Ya";
            this.beasiswayes.UseVisualStyleBackColor = true;
            // 
            // nominal
            // 
            this.nominal.Location = new System.Drawing.Point(96, 20);
            this.nominal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nominal.Name = "nominal";
            this.nominal.Size = new System.Drawing.Size(169, 22);
            this.nominal.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label24.Location = new System.Drawing.Point(7, 50);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label24.Size = new System.Drawing.Size(60, 24);
            this.label24.TabIndex = 1;
            this.label24.Text = "Beasiswa";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.label27.Location = new System.Drawing.Point(7, 18);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label27.Size = new System.Drawing.Size(82, 24);
            this.label27.TabIndex = 4;
            this.label27.Text = "Nominal baru";
            // 
            // bsimpan
            // 
            this.bsimpan.Location = new System.Drawing.Point(396, 326);
            this.bsimpan.Name = "bsimpan";
            this.bsimpan.Size = new System.Drawing.Size(139, 23);
            this.bsimpan.TabIndex = 10;
            this.bsimpan.Text = "SIMPAN";
            this.bsimpan.UseVisualStyleBackColor = true;
            this.bsimpan.Click += new System.EventHandler(this.bsimpan_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(234, 326);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(139, 23);
            this.bcancel.TabIndex = 10;
            this.bcancel.Text = "BATAL";
            this.bcancel.UseVisualStyleBackColor = true;
            // 
            // FormNominalKhususCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(552, 370);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bsimpan);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNominalKhususCRUD";
            this.Text = "FormNominalKhususCRUD";
            this.Load += new System.EventHandler(this.FormNominalKhususCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label angkatan;
        private System.Windows.Forms.Label prodi;
        private System.Windows.Forms.Label jurusan;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label nim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lgolongan;
        private System.Windows.Forms.Label lnominal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton beasiswayes;
        private System.Windows.Forms.NumericUpDown nominal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton beasiswano;
        private System.Windows.Forms.Button bsimpan;
        private System.Windows.Forms.Button bcancel;
    }
}