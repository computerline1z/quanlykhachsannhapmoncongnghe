namespace QUANLYCHAMCONG.PL.CMS
{
    partial class Toolbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbar));
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.imgtoolbar = new System.Windows.Forms.ImageList(this.components);
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnrefesh = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btntimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbshoft = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.ImageIndex = 1;
            this.btnthem.ImageList = this.imgtoolbar;
            this.btnthem.Location = new System.Drawing.Point(13, 6);
            this.btnthem.LookAndFeel.SkinName = "Blue";
            this.btnthem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 30);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // imgtoolbar
            // 
            this.imgtoolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgtoolbar.ImageStream")));
            this.imgtoolbar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgtoolbar.Images.SetKeyName(0, "xmag.ico");
            this.imgtoolbar.Images.SetKeyName(1, "add.ico");
            this.imgtoolbar.Images.SetKeyName(2, "button_cancel.ico");
            this.imgtoolbar.Images.SetKeyName(3, "Cancel.ico");
            this.imgtoolbar.Images.SetKeyName(4, "Delete.ico");
            this.imgtoolbar.Images.SetKeyName(5, "edit.ico");
            this.imgtoolbar.Images.SetKeyName(6, "ok.ico");
            this.imgtoolbar.Images.SetKeyName(7, "open.ico");
            this.imgtoolbar.Images.SetKeyName(8, "print.ico");
            this.imgtoolbar.Images.SetKeyName(9, "refresh.ico");
            this.imgtoolbar.Images.SetKeyName(10, "save_all.ico");
            this.imgtoolbar.Images.SetKeyName(11, "Excel.png");
            // 
            // btnxoa
            // 
            this.btnxoa.ImageIndex = 4;
            this.btnxoa.ImageList = this.imgtoolbar;
            this.btnxoa.Location = new System.Drawing.Point(95, 6);
            this.btnxoa.LookAndFeel.SkinName = "Blue";
            this.btnxoa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(71, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageIndex = 5;
            this.btnsua.ImageList = this.imgtoolbar;
            this.btnsua.Location = new System.Drawing.Point(177, 6);
            this.btnsua.LookAndFeel.SkinName = "Blue";
            this.btnsua.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(71, 30);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnin
            // 
            this.btnin.ImageIndex = 8;
            this.btnin.ImageList = this.imgtoolbar;
            this.btnin.Location = new System.Drawing.Point(259, 6);
            this.btnin.LookAndFeel.SkinName = "Blue";
            this.btnin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(71, 30);
            this.btnin.TabIndex = 3;
            this.btnin.Text = "In";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnrefesh
            // 
            this.btnrefesh.ImageIndex = 9;
            this.btnrefesh.ImageList = this.imgtoolbar;
            this.btnrefesh.Location = new System.Drawing.Point(341, 6);
            this.btnrefesh.LookAndFeel.SkinName = "Blue";
            this.btnrefesh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnrefesh.Name = "btnrefesh";
            this.btnrefesh.Size = new System.Drawing.Size(71, 30);
            this.btnrefesh.TabIndex = 4;
            this.btnrefesh.Text = "Undo";
            this.btnrefesh.Click += new System.EventHandler(this.btnrefesh_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageIndex = 10;
            this.btnluu.ImageList = this.imgtoolbar;
            this.btnluu.Location = new System.Drawing.Point(423, 6);
            this.btnluu.LookAndFeel.SkinName = "Blue";
            this.btnluu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(71, 30);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageIndex = 2;
            this.btnthoat.ImageList = this.imgtoolbar;
            this.btnthoat.Location = new System.Drawing.Point(587, 6);
            this.btnthoat.LookAndFeel.SkinName = "Blue";
            this.btnthoat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(71, 30);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.ImageIndex = 11;
            this.btntimkiem.ImageList = this.imgtoolbar;
            this.btntimkiem.Location = new System.Drawing.Point(505, 6);
            this.btntimkiem.LookAndFeel.SkinName = "Blue";
            this.btntimkiem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(71, 30);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Excel";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cmbshoft
            // 
            this.cmbshoft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbshoft.FormattingEnabled = true;
            this.cmbshoft.Location = new System.Drawing.Point(733, 11);
            this.cmbshoft.Name = "cmbshoft";
            this.cmbshoft.Size = new System.Drawing.Size(170, 21);
            this.cmbshoft.TabIndex = 8;
            this.cmbshoft.Visible = false;
            this.cmbshoft.SelectedIndexChanged += new System.EventHandler(this.cmbshoft_SelectedIndexChanged);
            // 
            // Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.cmbshoft);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnrefesh);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Name = "Toolbar";
            this.Size = new System.Drawing.Size(907, 43);
            this.Load += new System.EventHandler(this.Toolbar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnrefesh;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btntimkiem;
        private System.Windows.Forms.ImageList imgtoolbar;
        private System.Windows.Forms.ComboBox cmbshoft;
    }
}
