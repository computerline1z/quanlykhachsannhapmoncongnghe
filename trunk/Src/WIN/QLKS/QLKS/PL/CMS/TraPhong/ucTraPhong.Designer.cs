namespace QLKS.PL.CMS.TraPhong
{
    partial class ucTraPhong
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grd_ChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONGAYTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_LapHoaDon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Phiếu Thuê:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(175, 40);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(127, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Khách Hàng/Cơ Quan:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(175, 81);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(243, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(175, 120);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(299, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Địa Chỉ:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Location = new System.Drawing.Point(13, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(950, 170);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông Tin Căn Bản";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_LapHoaDon);
            this.groupControl2.Controls.Add(this.textEdit4);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.grd_ChiTiet);
            this.groupControl2.Location = new System.Drawing.Point(13, 206);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(950, 472);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Chi Tiết Hóa Đơn";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(601, 387);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit4.Size = new System.Drawing.Size(243, 24);
            this.textEdit4.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(483, 388);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tổng thành tiền:";
            // 
            // grd_ChiTiet
            // 
            this.grd_ChiTiet.Location = new System.Drawing.Point(26, 35);
            this.grd_ChiTiet.MainView = this.gridView1;
            this.grd_ChiTiet.Name = "grd_ChiTiet";
            this.grd_ChiTiet.Size = new System.Drawing.Size(904, 332);
            this.grd_ChiTiet.TabIndex = 0;
            this.grd_ChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.PHONG,
            this.SONGAYTHUE,
            this.DONGIA,
            this.THANHTIEN});
            this.gridView1.GridControl = this.grd_ChiTiet;
            this.gridView1.Name = "gridView1";
            // 
            // STT
            // 
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 66;
            // 
            // PHONG
            // 
            this.PHONG.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONG.AppearanceHeader.Options.UseFont = true;
            this.PHONG.AppearanceHeader.Options.UseTextOptions = true;
            this.PHONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PHONG.Caption = "Phòng";
            this.PHONG.Name = "PHONG";
            this.PHONG.Visible = true;
            this.PHONG.VisibleIndex = 1;
            this.PHONG.Width = 92;
            // 
            // SONGAYTHUE
            // 
            this.SONGAYTHUE.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SONGAYTHUE.AppearanceHeader.Options.UseFont = true;
            this.SONGAYTHUE.AppearanceHeader.Options.UseTextOptions = true;
            this.SONGAYTHUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SONGAYTHUE.Caption = "Số Ngày Thuê";
            this.SONGAYTHUE.Name = "SONGAYTHUE";
            this.SONGAYTHUE.Visible = true;
            this.SONGAYTHUE.VisibleIndex = 2;
            this.SONGAYTHUE.Width = 135;
            // 
            // DONGIA
            // 
            this.DONGIA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONGIA.AppearanceHeader.Options.UseFont = true;
            this.DONGIA.AppearanceHeader.Options.UseTextOptions = true;
            this.DONGIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DONGIA.Caption = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 135;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THANHTIEN.AppearanceHeader.Options.UseFont = true;
            this.THANHTIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.THANHTIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THANHTIEN.Caption = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Visible = true;
            this.THANHTIEN.VisibleIndex = 4;
            this.THANHTIEN.Width = 145;
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.Location = new System.Drawing.Point(397, 411);
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.Size = new System.Drawing.Size(113, 26);
            this.btn_LapHoaDon.TabIndex = 8;
            this.btn_LapHoaDon.Text = "Lập Hóa Đơn";
            // 
            // ucTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucTraPhong";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grd_ChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn PHONG;
        private DevExpress.XtraGrid.Columns.GridColumn SONGAYTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn THANHTIEN;
        private DevExpress.XtraEditors.SimpleButton btn_LapHoaDon;
    }
}
