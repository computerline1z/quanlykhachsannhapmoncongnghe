namespace QLKS.PL.CMS
{
    partial class UcRightDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDetailRoom1 = new QLKS.PL.CMS.UcDetailRoom();
            this.ucRightToolBar1 = new QLKS.PL.CMS.UcRightToolBar();
            this.ucListRoom1 = new QLKS.PL.CMS.UcListRoom();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ucDetailRoom1);
            this.groupBox1.Controls.Add(this.ucRightToolBar1);
            this.groupBox1.Controls.Add(this.ucListRoom1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ucDetailRoom1
            // 
            this.ucDetailRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDetailRoom1.BackColor = System.Drawing.Color.Transparent;
            this.ucDetailRoom1.Location = new System.Drawing.Point(-7, 443);
            this.ucDetailRoom1.Name = "ucDetailRoom1";
            this.ucDetailRoom1.Size = new System.Drawing.Size(1036, 99);
            this.ucDetailRoom1.TabIndex = 2;
            // 
            // ucRightToolBar1
            // 
            this.ucRightToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRightToolBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucRightToolBar1.Location = new System.Drawing.Point(4, 392);
            this.ucRightToolBar1.Name = "ucRightToolBar1";
            this.ucRightToolBar1.Size = new System.Drawing.Size(1000, 39);
            this.ucRightToolBar1.TabIndex = 1;
            // 
            // ucListRoom1
            // 
            this.ucListRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucListRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ucListRoom1.Location = new System.Drawing.Point(6, 10);
            this.ucListRoom1.Name = "ucListRoom1";
            this.ucListRoom1.Size = new System.Drawing.Size(998, 388);
            this.ucListRoom1.TabIndex = 0;
            // 
            // UcRightDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "UcRightDetail";
            this.Size = new System.Drawing.Size(1010, 567);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private UcListRoom ucListRoom1;
        private UcRightToolBar ucRightToolBar1;
        private UcDetailRoom ucDetailRoom1;
    }
}
