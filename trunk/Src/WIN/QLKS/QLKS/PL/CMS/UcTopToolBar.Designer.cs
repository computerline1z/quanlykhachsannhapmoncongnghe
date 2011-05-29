namespace QLKS.PL.CMS
{
    partial class UcTopToolBar
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
            this.pnuctoptoolbar = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btncheckout = new DevExpress.XtraEditors.SimpleButton();
            this.btncheckin = new DevExpress.XtraEditors.SimpleButton();
            this.pnuctoptoolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnuctoptoolbar
            // 
            this.pnuctoptoolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnuctoptoolbar.Controls.Add(this.simpleButton2);
            this.pnuctoptoolbar.Controls.Add(this.simpleButton1);
            this.pnuctoptoolbar.Controls.Add(this.btncheckout);
            this.pnuctoptoolbar.Controls.Add(this.btncheckin);
            this.pnuctoptoolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnuctoptoolbar.Location = new System.Drawing.Point(0, 0);
            this.pnuctoptoolbar.Name = "pnuctoptoolbar";
            this.pnuctoptoolbar.Size = new System.Drawing.Size(967, 51);
            this.pnuctoptoolbar.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = global::QLKS.Properties.Resources.Settings;
            this.simpleButton2.Location = new System.Drawing.Point(482, 7);
            this.simpleButton2.LookAndFeel.SkinName = "The Asphalt World";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 35);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Hệ thống";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::QLKS.Properties.Resources.Reports;
            this.simpleButton1.Location = new System.Drawing.Point(326, 7);
            this.simpleButton1.LookAndFeel.SkinName = "The Asphalt World";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(150, 35);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Thống kê";
            // 
            // btncheckout
            // 
            this.btncheckout.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.Appearance.Options.UseFont = true;
            this.btncheckout.Image = global::QLKS.Properties.Resources.Payment;
            this.btncheckout.Location = new System.Drawing.Point(169, 7);
            this.btncheckout.LookAndFeel.SkinName = "The Asphalt World";
            this.btncheckout.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(150, 35);
            this.btncheckout.TabIndex = 1;
            this.btncheckout.Text = "Trả phòng";
            // 
            // btncheckin
            // 
            this.btncheckin.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckin.Appearance.Options.UseFont = true;
            this.btncheckin.Image = global::QLKS.Properties.Resources.checkin;
            this.btncheckin.Location = new System.Drawing.Point(13, 7);
            this.btncheckin.LookAndFeel.SkinName = "The Asphalt World";
            this.btncheckin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(150, 35);
            this.btncheckin.TabIndex = 0;
            this.btncheckin.Text = "Đặt phòng";
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // UcTopToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnuctoptoolbar);
            this.Name = "UcTopToolBar";
            this.Size = new System.Drawing.Size(967, 51);
            this.pnuctoptoolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnuctoptoolbar;
        private DevExpress.XtraEditors.SimpleButton btncheckin;
        private DevExpress.XtraEditors.SimpleButton btncheckout;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
