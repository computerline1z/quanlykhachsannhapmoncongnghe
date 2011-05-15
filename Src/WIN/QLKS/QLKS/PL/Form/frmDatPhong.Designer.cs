namespace QLKS
{
    partial class frmDatPhong
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
            this.ucPhieuThue1 = new QLKS.PL.CMS.DatPhong.UcPhieuThue();
            this.lbx_DanhSachPhong = new DevExpress.XtraEditors.ListBoxControl();
            this.btn_XoaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.grp_DSPhong = new DevExpress.XtraEditors.GroupControl();
            this.btn_ThemPhong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbx_DanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_DSPhong)).BeginInit();
            this.grp_DSPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPhieuThue1
            // 
            this.ucPhieuThue1.BackColor = System.Drawing.Color.Transparent;
            this.ucPhieuThue1.ForeColor = System.Drawing.Color.Transparent;
            this.ucPhieuThue1.Location = new System.Drawing.Point(11, 23);
            this.ucPhieuThue1.Name = "ucPhieuThue1";
            this.ucPhieuThue1.Size = new System.Drawing.Size(800, 702);
            this.ucPhieuThue1.TabIndex = 0;
            // 
            // lbx_DanhSachPhong
            // 
            this.lbx_DanhSachPhong.Location = new System.Drawing.Point(7, 25);
            this.lbx_DanhSachPhong.Name = "lbx_DanhSachPhong";
            this.lbx_DanhSachPhong.Size = new System.Drawing.Size(184, 627);
            this.lbx_DanhSachPhong.TabIndex = 1;
            // 
            // btn_XoaPhong
            // 
            this.btn_XoaPhong.Location = new System.Drawing.Point(54, 658);
            this.btn_XoaPhong.Name = "btn_XoaPhong";
            this.btn_XoaPhong.Size = new System.Drawing.Size(96, 21);
            this.btn_XoaPhong.TabIndex = 2;
            this.btn_XoaPhong.Text = "Xóa Phỏng";
            // 
            // grp_DSPhong
            // 
            this.grp_DSPhong.Controls.Add(this.btn_XoaPhong);
            this.grp_DSPhong.Controls.Add(this.lbx_DanhSachPhong);
            this.grp_DSPhong.Location = new System.Drawing.Point(816, 30);
            this.grp_DSPhong.Name = "grp_DSPhong";
            this.grp_DSPhong.Size = new System.Drawing.Size(196, 684);
            this.grp_DSPhong.TabIndex = 3;
            this.grp_DSPhong.Text = "Danh Sách Phòng";
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.Location = new System.Drawing.Point(409, 726);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(133, 30);
            this.btn_ThemPhong.TabIndex = 4;
            this.btn_ThemPhong.Text = "Thêm Phòng";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btn_ThemPhong);
            this.Controls.Add(this.grp_DSPhong);
            this.Controls.Add(this.ucPhieuThue1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            ((System.ComponentModel.ISupportInitialize)(this.lbx_DanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_DSPhong)).EndInit();
            this.grp_DSPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.PL.CMS.DatPhong.UcPhieuThue ucPhieuThue1;
        private DevExpress.XtraEditors.ListBoxControl lbx_DanhSachPhong;
        private DevExpress.XtraEditors.SimpleButton btn_XoaPhong;
        private DevExpress.XtraEditors.GroupControl grp_DSPhong;
        private DevExpress.XtraEditors.SimpleButton btn_ThemPhong;
    }
}