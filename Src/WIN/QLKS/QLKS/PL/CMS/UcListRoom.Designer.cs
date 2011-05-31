namespace QLKS.PL.CMS
{
    partial class UcListRoom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcListRoom));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.All = new DevExpress.XtraTab.XtraTabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.VIP = new DevExpress.XtraTab.XtraTabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Normal = new DevExpress.XtraTab.XtraTabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.All.SuspendLayout();
            this.VIP.SuspendLayout();
            this.Normal.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.LookAndFeel.SkinName = "Blue";
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.All;
            this.xtraTabControl1.Size = new System.Drawing.Size(968, 459);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.All,
            this.VIP,
            this.Normal});
            // 
            // All
            // 
            this.All.Controls.Add(this.listView1);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(961, 431);
            this.All.Text = "ALL";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(-2, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(965, 436);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VIP
            // 
            this.VIP.Controls.Add(this.listView3);
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(961, 431);
            this.VIP.Text = "VIP";
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Location = new System.Drawing.Point(-2, -2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(965, 435);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "using.png");
            this.imageList1.Images.SetKeyName(1, "empty.png");
            // 
            // Normal
            // 
            this.Normal.Controls.Add(this.listView2);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(961, 431);
            this.Normal.Text = "Normal";
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Location = new System.Drawing.Point(-2, -3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(965, 436);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // UcListRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "UcListRoom";
            this.Size = new System.Drawing.Size(968, 462);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.All.ResumeLayout(false);
            this.VIP.ResumeLayout(false);
            this.Normal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage All;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraTab.XtraTabPage VIP;
        private System.Windows.Forms.ListView listView3;
        private DevExpress.XtraTab.XtraTabPage Normal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView2;

    }
}
