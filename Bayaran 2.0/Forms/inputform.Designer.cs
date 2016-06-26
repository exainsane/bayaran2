namespace Bayaran_2._0.Forms
{
    partial class inputform
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
            this.FormFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.bfinish = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.ltitle = new System.Windows.Forms.Label();
            this.lbttl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormFlow
            // 
            this.FormFlow.AutoScroll = true;
            this.FormFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FormFlow.Location = new System.Drawing.Point(13, 49);
            this.FormFlow.Name = "FormFlow";
            this.FormFlow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FormFlow.Size = new System.Drawing.Size(345, 377);
            this.FormFlow.TabIndex = 0;
            this.FormFlow.WrapContents = false;
            // 
            // bfinish
            // 
            this.bfinish.Location = new System.Drawing.Point(13, 435);
            this.bfinish.Name = "bfinish";
            this.bfinish.Size = new System.Drawing.Size(157, 34);
            this.bfinish.TabIndex = 1;
            this.bfinish.Text = "Save";
            this.bfinish.UseVisualStyleBackColor = true;
            this.bfinish.Click += new System.EventHandler(this.bfinish_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(201, 435);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(157, 34);
            this.bcancel.TabIndex = 1;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // ltitle
            // 
            this.ltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ltitle.Location = new System.Drawing.Point(13, 13);
            this.ltitle.Name = "ltitle";
            this.ltitle.Size = new System.Drawing.Size(345, 23);
            this.ltitle.TabIndex = 2;
            this.ltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbttl
            // 
            this.lbttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbttl.Location = new System.Drawing.Point(13, 13);
            this.lbttl.Name = "lbttl";
            this.lbttl.Size = new System.Drawing.Size(345, 33);
            this.lbttl.TabIndex = 3;
            this.lbttl.Text = "label1";
            this.lbttl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 481);
            this.Controls.Add(this.lbttl);
            this.Controls.Add(this.ltitle);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bfinish);
            this.Controls.Add(this.FormFlow);
            this.Name = "inputform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~~";
            this.Load += new System.EventHandler(this.inputform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bfinish;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Label ltitle;
        public System.Windows.Forms.FlowLayoutPanel FormFlow;
        private System.Windows.Forms.Label lbttl;

    }
}