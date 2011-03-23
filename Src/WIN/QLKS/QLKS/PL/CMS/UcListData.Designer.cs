namespace QLKS.PL.CMS
{
    partial class UcListData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcListData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDisplayData1 = new QLKS.PL.CMS.UcDisplayData();
            this.ucToolBar1 = new QLKS.PL.CMS.UcToolBar();
            this.ucLink1 = new QLKS.PL.CMS.UcLink();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucDisplayData1);
            this.groupBox1.Controls.Add(this.ucToolBar1);
            this.groupBox1.Controls.Add(this.ucLink1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 564);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ucDisplayData1
            // 
            this.ucDisplayData1.Location = new System.Drawing.Point(6, 80);
            this.ucDisplayData1.Name = "ucDisplayData1";
            this.ucDisplayData1.Size = new System.Drawing.Size(993, 478);
            this.ucDisplayData1.TabIndex = 2;
            // 
            // ucToolBar1
            // 
            this.ucToolBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucToolBar1.Location = new System.Drawing.Point(-10, 38);
            this.ucToolBar1.Name = "ucToolBar1";
            this.ucToolBar1.Size = new System.Drawing.Size(907, 43);
            this.ucToolBar1.TabIndex = 1;
            // 
            // ucLink1
            // 
            this.ucLink1.BackColor = System.Drawing.Color.Transparent;
            this.ucLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLink1.BackgroundImage")));
            this.ucLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLink1.Location = new System.Drawing.Point(6, 11);
            this.ucLink1.Name = "ucLink1";
            this.ucLink1.Size = new System.Drawing.Size(995, 27);
            this.ucLink1.TabIndex = 0;
            // 
            // UcListData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "UcListData";
            this.Size = new System.Drawing.Size(1010, 567);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private UcLink ucLink1;
        private UcToolBar ucToolBar1;
        private UcDisplayData ucDisplayData1;

    }
}
