namespace Bayaran_2._0.forms
{
    partial class installer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.not_1 = new System.Windows.Forms.Label();
            this.not_2 = new System.Windows.Forms.Label();
            this.not_3 = new System.Windows.Forms.Label();
            this.panel_section_1 = new System.Windows.Forms.Panel();
            this.b_next = new System.Windows.Forms.Button();
            this.t_dbname = new System.Windows.Forms.TextBox();
            this.t_admin_uname = new System.Windows.Forms.TextBox();
            this.t_admin_pw = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_addr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_section_2 = new System.Windows.Forms.Panel();
            this.l_progress_count = new System.Windows.Forms.Label();
            this.l_progress_status = new System.Windows.Forms.Label();
            this.p_progressBar = new System.Windows.Forms.ProgressBar();
            this.t_log = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_section_1.SuspendLayout();
            this.panel_section_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.b_close);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_section_1);
            this.splitContainer1.Panel2.Controls.Add(this.panel_section_2);
            this.splitContainer1.Size = new System.Drawing.Size(662, 257);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(3, 227);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(149, 23);
            this.b_close.TabIndex = 1;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Visible = false;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.not_1);
            this.flowLayoutPanel1.Controls.Add(this.not_2);
            this.flowLayoutPanel1.Controls.Add(this.not_3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // not_1
            // 
            this.not_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.not_1.AutoSize = true;
            this.not_1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_1.Location = new System.Drawing.Point(5, 5);
            this.not_1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.not_1.Name = "not_1";
            this.not_1.Size = new System.Drawing.Size(108, 14);
            this.not_1.TabIndex = 0;
            this.not_1.Text = "Detail Database";
            this.not_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // not_2
            // 
            this.not_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.not_2.AutoSize = true;
            this.not_2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_2.Location = new System.Drawing.Point(5, 29);
            this.not_2.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.not_2.Name = "not_2";
            this.not_2.Size = new System.Drawing.Size(108, 14);
            this.not_2.TabIndex = 1;
            this.not_2.Text = "Install";
            this.not_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // not_3
            // 
            this.not_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.not_3.AutoSize = true;
            this.not_3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_3.Location = new System.Drawing.Point(5, 53);
            this.not_3.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.not_3.Name = "not_3";
            this.not_3.Size = new System.Drawing.Size(108, 14);
            this.not_3.TabIndex = 2;
            this.not_3.Text = "Finished";
            this.not_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_section_1
            // 
            this.panel_section_1.Controls.Add(this.b_next);
            this.panel_section_1.Controls.Add(this.t_dbname);
            this.panel_section_1.Controls.Add(this.t_admin_uname);
            this.panel_section_1.Controls.Add(this.t_admin_pw);
            this.panel_section_1.Controls.Add(this.t_password);
            this.panel_section_1.Controls.Add(this.label7);
            this.panel_section_1.Controls.Add(this.label8);
            this.panel_section_1.Controls.Add(this.label1);
            this.panel_section_1.Controls.Add(this.label6);
            this.panel_section_1.Controls.Add(this.label5);
            this.panel_section_1.Controls.Add(this.t_username);
            this.panel_section_1.Controls.Add(this.label4);
            this.panel_section_1.Controls.Add(this.t_addr);
            this.panel_section_1.Controls.Add(this.label3);
            this.panel_section_1.Controls.Add(this.label9);
            this.panel_section_1.Controls.Add(this.label2);
            this.panel_section_1.Location = new System.Drawing.Point(1, 0);
            this.panel_section_1.Name = "panel_section_1";
            this.panel_section_1.Size = new System.Drawing.Size(497, 245);
            this.panel_section_1.TabIndex = 11;
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(364, 214);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(124, 23);
            this.b_next.TabIndex = 6;
            this.b_next.Text = "Lanjutkan";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // t_dbname
            // 
            this.t_dbname.Location = new System.Drawing.Point(7, 182);
            this.t_dbname.Name = "t_dbname";
            this.t_dbname.Size = new System.Drawing.Size(221, 20);
            this.t_dbname.TabIndex = 3;
            // 
            // t_admin_uname
            // 
            this.t_admin_uname.Location = new System.Drawing.Point(241, 53);
            this.t_admin_uname.Name = "t_admin_uname";
            this.t_admin_uname.Size = new System.Drawing.Size(221, 20);
            this.t_admin_uname.TabIndex = 4;
            // 
            // t_admin_pw
            // 
            this.t_admin_pw.Location = new System.Drawing.Point(241, 97);
            this.t_admin_pw.Name = "t_admin_pw";
            this.t_admin_pw.Size = new System.Drawing.Size(221, 20);
            this.t_admin_pw.TabIndex = 5;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(7, 139);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(221, 20);
            this.t_password.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(238, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 78);
            this.label7.TabIndex = 1;
            this.label7.Text = "Catatan : \r\n- Database akan dibuat apabila database \r\n    tidak ditemukan\r\n- Apab" +
    "ila ada nama database yang sama \r\n    maka sistem akan menghapus database\r\n    s" +
    "ebelumnya\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(238, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(238, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(4, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(4, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(7, 97);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(221, 20);
            this.t_username.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(4, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // t_addr
            // 
            this.t_addr.Location = new System.Drawing.Point(7, 55);
            this.t_addr.Name = "t_addr";
            this.t_addr.Size = new System.Drawing.Size(221, 20);
            this.t_addr.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(4, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alamat Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(238, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Detail Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detail Database";
            // 
            // panel_section_2
            // 
            this.panel_section_2.Controls.Add(this.l_progress_count);
            this.panel_section_2.Controls.Add(this.l_progress_status);
            this.panel_section_2.Controls.Add(this.p_progressBar);
            this.panel_section_2.Controls.Add(this.t_log);
            this.panel_section_2.Location = new System.Drawing.Point(1, 0);
            this.panel_section_2.Name = "panel_section_2";
            this.panel_section_2.Size = new System.Drawing.Size(497, 245);
            this.panel_section_2.TabIndex = 0;
            // 
            // l_progress_count
            // 
            this.l_progress_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_progress_count.AutoSize = true;
            this.l_progress_count.BackColor = System.Drawing.Color.Transparent;
            this.l_progress_count.Location = new System.Drawing.Point(439, 9);
            this.l_progress_count.Name = "l_progress_count";
            this.l_progress_count.Size = new System.Drawing.Size(0, 13);
            this.l_progress_count.TabIndex = 10;
            // 
            // l_progress_status
            // 
            this.l_progress_status.AutoSize = true;
            this.l_progress_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.l_progress_status.Location = new System.Drawing.Point(4, 6);
            this.l_progress_status.Name = "l_progress_status";
            this.l_progress_status.Size = new System.Drawing.Size(45, 16);
            this.l_progress_status.TabIndex = 9;
            this.l_progress_status.Text = "Status";
            // 
            // p_progressBar
            // 
            this.p_progressBar.Location = new System.Drawing.Point(7, 26);
            this.p_progressBar.Name = "p_progressBar";
            this.p_progressBar.Size = new System.Drawing.Size(485, 23);
            this.p_progressBar.TabIndex = 8;
            // 
            // t_log
            // 
            this.t_log.BackColor = System.Drawing.SystemColors.ControlLight;
            this.t_log.Location = new System.Drawing.Point(7, 55);
            this.t_log.Multiline = true;
            this.t_log.Name = "t_log";
            this.t_log.ReadOnly = true;
            this.t_log.Size = new System.Drawing.Size(485, 183);
            this.t_log.TabIndex = 7;
            // 
            // installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 257);
            this.Controls.Add(this.splitContainer1);
            this.Name = "installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfigurasi Awal Program";
            this.Load += new System.EventHandler(this.installer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel_section_1.ResumeLayout(false);
            this.panel_section_1.PerformLayout();
            this.panel_section_2.ResumeLayout(false);
            this.panel_section_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label not_1;
        private System.Windows.Forms.Label not_2;
        private System.Windows.Forms.Label not_3;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Panel panel_section_2;
        private System.Windows.Forms.Panel panel_section_1;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.TextBox t_dbname;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_addr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_progress_count;
        private System.Windows.Forms.Label l_progress_status;
        private System.Windows.Forms.ProgressBar p_progressBar;
        public System.Windows.Forms.TextBox t_log;
        private System.Windows.Forms.TextBox t_admin_uname;
        private System.Windows.Forms.TextBox t_admin_pw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;

    }
}