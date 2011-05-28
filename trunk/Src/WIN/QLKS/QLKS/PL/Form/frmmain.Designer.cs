namespace QLKS
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.grmain = new System.Windows.Forms.GroupBox();
            this.ucLeftToolBar1 = new QLKS.PL.CMS.UcLeftToolBar();
            this.ucStatusHotelToolBar1 = new QLKS.PL.CMS.UcStatusHotelToolBar();
            this.ucTopToolBar1 = new QLKS.PL.CMS.UcTopToolBar();
            this.SuspendLayout();
            // 
            // grmain
            // 
            this.grmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grmain.Location = new System.Drawing.Point(244, 47);
            this.grmain.Name = "grmain";
            this.grmain.Size = new System.Drawing.Size(783, 592);
            this.grmain.TabIndex = 4;
            this.grmain.TabStop = false;
            // 
            // ucLeftToolBar1
            // 
            this.ucLeftToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ucLeftToolBar1.AutoSize = true;
            this.ucLeftToolBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucLeftToolBar1.Location = new System.Drawing.Point(9, 46);
            this.ucLeftToolBar1.Name = "ucLeftToolBar1";
            this.ucLeftToolBar1.Size = new System.Drawing.Size(229, 416);
            this.ucLeftToolBar1.TabIndex = 3;
            // 
            // ucStatusHotelToolBar1
            // 
            this.ucStatusHotelToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucStatusHotelToolBar1.Location = new System.Drawing.Point(12, 457);
            this.ucStatusHotelToolBar1.Name = "ucStatusHotelToolBar1";
            this.ucStatusHotelToolBar1.Size = new System.Drawing.Size(224, 182);
            this.ucStatusHotelToolBar1.TabIndex = 2;
            // 
            // ucTopToolBar1
            // 
            this.ucTopToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTopToolBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucTopToolBar1.Location = new System.Drawing.Point(0, 3);
            this.ucTopToolBar1.Name = "ucTopToolBar1";
            this.ucTopToolBar1.Size = new System.Drawing.Size(1027, 51);
            this.ucTopToolBar1.TabIndex = 0;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 657);
            this.Controls.Add(this.grmain);
            this.Controls.Add(this.ucLeftToolBar1);
            this.Controls.Add(this.ucStatusHotelToolBar1);
            this.Controls.Add(this.ucTopToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Hotel Systems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLKS.PL.CMS.UcTopToolBar ucTopToolBar1;
        private QLKS.PL.CMS.UcStatusHotelToolBar ucStatusHotelToolBar1;
        private QLKS.PL.CMS.UcLeftToolBar ucLeftToolBar1;
        private System.Windows.Forms.GroupBox grmain;
    }
}