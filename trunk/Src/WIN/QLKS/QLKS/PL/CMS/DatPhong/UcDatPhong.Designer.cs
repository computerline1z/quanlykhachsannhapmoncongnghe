namespace QLKS.PL.CMS.DatPhong
{
    partial class UcDatPhong
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
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_begindate = new DevExpress.XtraEditors.LabelControl();
            this.lbl_BeginDateText = new DevExpress.XtraEditors.LabelControl();
            this.grv_khachang_phong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIKHACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PASSPORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_phong = new DevExpress.XtraEditors.GroupControl();
            this.btn_BoKhach = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_SuaKhach = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemKhach = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Quan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_Quan = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ThanhPho = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_ThanhPho = new DevExpress.XtraEditors.LabelControl();
            this.cmb_QuocGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_QuocGia = new DevExpress.XtraEditors.LabelControl();
            this.txt_SoDT = new DevExpress.XtraEditors.TextEdit();
            this.lbl_SoDT = new DevExpress.XtraEditors.LabelControl();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_DiaChi = new DevExpress.XtraEditors.LabelControl();
            this.txt_Ten = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Ten = new DevExpress.XtraEditors.LabelControl();
            this.txt_Ho = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Ho = new DevExpress.XtraEditors.LabelControl();
            this.txt_Passport = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Passport = new DevExpress.XtraEditors.LabelControl();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.lbl_CMND = new DevExpress.XtraEditors.LabelControl();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_khachang_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_phong)).BeginInit();
            this.grp_phong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Quan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ThanhPho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_QuocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Passport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(84, 33);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(149, 20);
            this.comboBoxEdit1.TabIndex = 0;
            // 
            // lbl_begindate
            // 
            this.lbl_begindate.Location = new System.Drawing.Point(340, 36);
            this.lbl_begindate.Name = "lbl_begindate";
            this.lbl_begindate.Size = new System.Drawing.Size(56, 13);
            this.lbl_begindate.TabIndex = 1;
            this.lbl_begindate.Text = "Begin Date:";
            // 
            // lbl_BeginDateText
            // 
            this.lbl_BeginDateText.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_BeginDateText.Appearance.Options.UseBackColor = true;
            this.lbl_BeginDateText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lbl_BeginDateText.Location = new System.Drawing.Point(412, 34);
            this.lbl_BeginDateText.Name = "lbl_BeginDateText";
            this.lbl_BeginDateText.Size = new System.Drawing.Size(52, 17);
            this.lbl_BeginDateText.TabIndex = 2;
            this.lbl_BeginDateText.Text = "dd/mm/yy";
            // 
            // grv_khachang_phong
            // 
            this.grv_khachang_phong.Location = new System.Drawing.Point(5, 90);
            this.grv_khachang_phong.MainView = this.gridView1;
            this.grv_khachang_phong.Name = "grv_khachang_phong";
            this.grv_khachang_phong.Size = new System.Drawing.Size(790, 150);
            this.grv_khachang_phong.TabIndex = 3;
            this.grv_khachang_phong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.KHACHHANG,
            this.LOAIKHACH,
            this.CMND,
            this.PASSPORT,
            this.DIACHI});
            this.gridView1.GridControl = this.grv_khachang_phong;
            this.gridView1.Name = "gridView1";
            // 
            // STT
            // 
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            // 
            // KHACHHANG
            // 
            this.KHACHHANG.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KHACHHANG.AppearanceHeader.Options.UseFont = true;
            this.KHACHHANG.AppearanceHeader.Options.UseTextOptions = true;
            this.KHACHHANG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KHACHHANG.Caption = "Khách Hàng";
            this.KHACHHANG.Name = "KHACHHANG";
            this.KHACHHANG.Visible = true;
            this.KHACHHANG.VisibleIndex = 1;
            // 
            // LOAIKHACH
            // 
            this.LOAIKHACH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAIKHACH.AppearanceHeader.Options.UseFont = true;
            this.LOAIKHACH.AppearanceHeader.Options.UseTextOptions = true;
            this.LOAIKHACH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LOAIKHACH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LOAIKHACH.Caption = "Loại Khách";
            this.LOAIKHACH.Name = "LOAIKHACH";
            this.LOAIKHACH.Visible = true;
            this.LOAIKHACH.VisibleIndex = 2;
            // 
            // CMND
            // 
            this.CMND.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND.AppearanceHeader.Options.UseFont = true;
            this.CMND.AppearanceHeader.Options.UseTextOptions = true;
            this.CMND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CMND.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CMND.Caption = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 3;
            // 
            // PASSPORT
            // 
            this.PASSPORT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSPORT.AppearanceHeader.Options.UseFont = true;
            this.PASSPORT.AppearanceHeader.Options.UseTextOptions = true;
            this.PASSPORT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PASSPORT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PASSPORT.Caption = "Passport";
            this.PASSPORT.Name = "PASSPORT";
            this.PASSPORT.Visible = true;
            this.PASSPORT.VisibleIndex = 4;
            // 
            // DIACHI
            // 
            this.DIACHI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIACHI.AppearanceHeader.Options.UseFont = true;
            this.DIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.DIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIACHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DIACHI.Caption = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 5;
            // 
            // grp_phong
            // 
            this.grp_phong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grp_phong.Appearance.Options.UseBackColor = true;
            this.grp_phong.Controls.Add(this.btn_BoKhach);
            this.grp_phong.Controls.Add(this.labelControl1);
            this.grp_phong.Controls.Add(this.grv_khachang_phong);
            this.grp_phong.Controls.Add(this.comboBoxEdit1);
            this.grp_phong.Controls.Add(this.lbl_BeginDateText);
            this.grp_phong.Controls.Add(this.lbl_begindate);
            this.grp_phong.Location = new System.Drawing.Point(1, 8);
            this.grp_phong.Name = "grp_phong";
            this.grp_phong.Size = new System.Drawing.Size(798, 289);
            this.grp_phong.TabIndex = 4;
            this.grp_phong.Text = "Thông Tin Phòng";
            // 
            // btn_BoKhach
            // 
            this.btn_BoKhach.Location = new System.Drawing.Point(364, 246);
            this.btn_BoKhach.Name = "btn_BoKhach";
            this.btn_BoKhach.Size = new System.Drawing.Size(120, 23);
            this.btn_BoKhach.TabIndex = 21;
            this.btn_BoKhach.Text = "Bỏ Khách";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Phòng:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_SuaKhach);
            this.groupControl1.Controls.Add(this.btn_ThemKhach);
            this.groupControl1.Controls.Add(this.cmb_Quan);
            this.groupControl1.Controls.Add(this.lbl_Quan);
            this.groupControl1.Controls.Add(this.cmb_ThanhPho);
            this.groupControl1.Controls.Add(this.lbl_ThanhPho);
            this.groupControl1.Controls.Add(this.cmb_QuocGia);
            this.groupControl1.Controls.Add(this.lbl_QuocGia);
            this.groupControl1.Controls.Add(this.txt_SoDT);
            this.groupControl1.Controls.Add(this.lbl_SoDT);
            this.groupControl1.Controls.Add(this.txt_DiaChi);
            this.groupControl1.Controls.Add(this.lbl_DiaChi);
            this.groupControl1.Controls.Add(this.txt_Ten);
            this.groupControl1.Controls.Add(this.lbl_Ten);
            this.groupControl1.Controls.Add(this.txt_Ho);
            this.groupControl1.Controls.Add(this.lbl_Ho);
            this.groupControl1.Controls.Add(this.txt_Passport);
            this.groupControl1.Controls.Add(this.lbl_Passport);
            this.groupControl1.Controls.Add(this.txt_CMND);
            this.groupControl1.Controls.Add(this.lbl_CMND);
            this.groupControl1.Controls.Add(this.shapeContainer1);
            this.groupControl1.Location = new System.Drawing.Point(1, 316);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 377);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin khách hàng";
            // 
            // btn_SuaKhach
            // 
            this.btn_SuaKhach.Location = new System.Drawing.Point(403, 338);
            this.btn_SuaKhach.Name = "btn_SuaKhach";
            this.btn_SuaKhach.Size = new System.Drawing.Size(120, 23);
            this.btn_SuaKhach.TabIndex = 20;
            this.btn_SuaKhach.Text = "Sửa Thông Tin";
            // 
            // btn_ThemKhach
            // 
            this.btn_ThemKhach.Location = new System.Drawing.Point(266, 338);
            this.btn_ThemKhach.Name = "btn_ThemKhach";
            this.btn_ThemKhach.Size = new System.Drawing.Size(120, 23);
            this.btn_ThemKhach.TabIndex = 19;
            this.btn_ThemKhach.Text = "Thêm Khách";
            // 
            // cmb_Quan
            // 
            this.cmb_Quan.Location = new System.Drawing.Point(241, 285);
            this.cmb_Quan.Name = "cmb_Quan";
            this.cmb_Quan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Quan.Size = new System.Drawing.Size(135, 20);
            this.cmb_Quan.TabIndex = 18;
            // 
            // lbl_Quan
            // 
            this.lbl_Quan.Location = new System.Drawing.Point(162, 288);
            this.lbl_Quan.Name = "lbl_Quan";
            this.lbl_Quan.Size = new System.Drawing.Size(30, 13);
            this.lbl_Quan.TabIndex = 17;
            this.lbl_Quan.Text = "Quận:";
            // 
            // cmb_ThanhPho
            // 
            this.cmb_ThanhPho.Location = new System.Drawing.Point(241, 250);
            this.cmb_ThanhPho.Name = "cmb_ThanhPho";
            this.cmb_ThanhPho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ThanhPho.Size = new System.Drawing.Size(135, 20);
            this.cmb_ThanhPho.TabIndex = 16;
            // 
            // lbl_ThanhPho
            // 
            this.lbl_ThanhPho.Location = new System.Drawing.Point(162, 253);
            this.lbl_ThanhPho.Name = "lbl_ThanhPho";
            this.lbl_ThanhPho.Size = new System.Drawing.Size(55, 13);
            this.lbl_ThanhPho.TabIndex = 15;
            this.lbl_ThanhPho.Text = "Thành Phố:";
            // 
            // cmb_QuocGia
            // 
            this.cmb_QuocGia.Location = new System.Drawing.Point(241, 215);
            this.cmb_QuocGia.Name = "cmb_QuocGia";
            this.cmb_QuocGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_QuocGia.Size = new System.Drawing.Size(135, 20);
            this.cmb_QuocGia.TabIndex = 14;
            // 
            // lbl_QuocGia
            // 
            this.lbl_QuocGia.Location = new System.Drawing.Point(162, 218);
            this.lbl_QuocGia.Name = "lbl_QuocGia";
            this.lbl_QuocGia.Size = new System.Drawing.Size(47, 13);
            this.lbl_QuocGia.TabIndex = 13;
            this.lbl_QuocGia.Text = "Quốc Gia:";
            // 
            // txt_SoDT
            // 
            this.txt_SoDT.Location = new System.Drawing.Point(241, 184);
            this.txt_SoDT.Name = "txt_SoDT";
            this.txt_SoDT.Size = new System.Drawing.Size(135, 20);
            this.txt_SoDT.TabIndex = 12;
            // 
            // lbl_SoDT
            // 
            this.lbl_SoDT.Location = new System.Drawing.Point(162, 187);
            this.lbl_SoDT.Name = "lbl_SoDT";
            this.lbl_SoDT.Size = new System.Drawing.Size(70, 13);
            this.lbl_SoDT.TabIndex = 11;
            this.lbl_SoDT.Text = "Số Điện Thoại:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(240, 153);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(394, 20);
            this.txt_DiaChi.TabIndex = 9;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.Location = new System.Drawing.Point(162, 156);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(38, 13);
            this.lbl_DiaChi.TabIndex = 8;
            this.lbl_DiaChi.Text = "Địa Chỉ:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(640, 88);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(110, 20);
            this.txt_Ten.TabIndex = 7;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.Location = new System.Drawing.Point(612, 91);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(22, 13);
            this.lbl_Ten.TabIndex = 6;
            this.lbl_Ten.Text = "Tên:";
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(496, 88);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(110, 20);
            this.txt_Ho.TabIndex = 5;
            // 
            // lbl_Ho
            // 
            this.lbl_Ho.Location = new System.Drawing.Point(473, 91);
            this.lbl_Ho.Name = "lbl_Ho";
            this.lbl_Ho.Size = new System.Drawing.Size(17, 13);
            this.lbl_Ho.TabIndex = 4;
            this.lbl_Ho.Text = "Họ:";
            // 
            // txt_Passport
            // 
            this.txt_Passport.Location = new System.Drawing.Point(124, 93);
            this.txt_Passport.Name = "txt_Passport";
            this.txt_Passport.Size = new System.Drawing.Size(110, 20);
            this.txt_Passport.TabIndex = 3;
            // 
            // lbl_Passport
            // 
            this.lbl_Passport.Location = new System.Drawing.Point(64, 96);
            this.lbl_Passport.Name = "lbl_Passport";
            this.lbl_Passport.Size = new System.Drawing.Size(46, 13);
            this.lbl_Passport.TabIndex = 2;
            this.lbl_Passport.Text = "Passport:";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(124, 58);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(110, 20);
            this.txt_CMND.TabIndex = 1;
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.Location = new System.Drawing.Point(64, 61);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(33, 13);
            this.lbl_CMND.TabIndex = 0;
            this.lbl_CMND.Text = "CMND:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(794, 353);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 41;
            this.lineShape1.X2 = 746;
            this.lineShape1.Y1 = 110;
            this.lineShape1.Y2 = 110;
            // 
            // UcPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grp_phong);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "UcPhieuThue";
            this.Size = new System.Drawing.Size(800, 702);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_khachang_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_phong)).EndInit();
            this.grp_phong.ResumeLayout(false);
            this.grp_phong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Quan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ThanhPho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_QuocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Passport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl lbl_begindate;
        private DevExpress.XtraEditors.LabelControl lbl_BeginDateText;
        private DevExpress.XtraGrid.GridControl grv_khachang_phong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIKHACH;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn PASSPORT;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraEditors.GroupControl grp_phong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbl_CMND;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_Ten;
        private DevExpress.XtraEditors.LabelControl lbl_Ten;
        private DevExpress.XtraEditors.TextEdit txt_Ho;
        private DevExpress.XtraEditors.LabelControl lbl_Ho;
        private DevExpress.XtraEditors.TextEdit txt_Passport;
        private DevExpress.XtraEditors.LabelControl lbl_Passport;
        private DevExpress.XtraEditors.LabelControl lbl_QuocGia;
        private DevExpress.XtraEditors.TextEdit txt_SoDT;
        private DevExpress.XtraEditors.LabelControl lbl_SoDT;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.LabelControl lbl_DiaChi;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Quan;
        private DevExpress.XtraEditors.LabelControl lbl_Quan;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ThanhPho;
        private DevExpress.XtraEditors.LabelControl lbl_ThanhPho;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_QuocGia;
        private DevExpress.XtraEditors.SimpleButton btn_ThemKhach;
        private DevExpress.XtraEditors.SimpleButton btn_BoKhach;
        private DevExpress.XtraEditors.SimpleButton btn_SuaKhach;

    }
}
