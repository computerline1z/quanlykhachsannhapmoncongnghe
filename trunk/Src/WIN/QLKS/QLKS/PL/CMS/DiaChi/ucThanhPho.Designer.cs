namespace QLKS.PL.CMS.DiaChi
{
    partial class ucThanhPho
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
            this.txt_MaThanhPho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenThanhPho = new DevExpress.XtraEditors.TextEdit();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_QuocGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_ThanhPho = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaThanhPho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenThanhPho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_QuocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ThanhPho)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(222, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Thành Phố:";
            // 
            // txt_MaThanhPho
            // 
            this.txt_MaThanhPho.Location = new System.Drawing.Point(309, 31);
            this.txt_MaThanhPho.Name = "txt_MaThanhPho";
            this.txt_MaThanhPho.Size = new System.Drawing.Size(132, 20);
            this.txt_MaThanhPho.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(450, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Thành Phố:";
            // 
            // txt_TenThanhPho
            // 
            this.txt_TenThanhPho.Location = new System.Drawing.Point(537, 31);
            this.txt_TenThanhPho.Name = "txt_TenThanhPho";
            this.txt_TenThanhPho.Size = new System.Drawing.Size(132, 20);
            this.txt_TenThanhPho.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(691, 28);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Location = new System.Drawing.Point(790, 28);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(85, 23);
            this.Btn_Sua.TabIndex = 5;
            this.Btn_Sua.Text = "Sửa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(898, 28);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 23);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Quốc Gia:";
            // 
            // cbx_QuocGia
            // 
            this.cbx_QuocGia.Location = new System.Drawing.Point(87, 31);
            this.cbx_QuocGia.Name = "cbx_QuocGia";
            this.cbx_QuocGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_QuocGia.Size = new System.Drawing.Size(118, 20);
            this.cbx_QuocGia.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbx_QuocGia);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btn_Xoa);
            this.groupControl1.Controls.Add(this.Btn_Sua);
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.txt_TenThanhPho);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_MaThanhPho);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 125);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 72);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Thành Phố";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_ThanhPho;
            this.gridView1.Name = "gridView1";
            // 
            // grd_ThanhPho
            // 
            this.grd_ThanhPho.Location = new System.Drawing.Point(4, 3);
            this.grd_ThanhPho.MainView = this.gridView1;
            this.grd_ThanhPho.Name = "grd_ThanhPho";
            this.grd_ThanhPho.Size = new System.Drawing.Size(990, 120);
            this.grd_ThanhPho.TabIndex = 3;
            this.grd_ThanhPho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ucThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grd_ThanhPho);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucThanhPho";
            this.Size = new System.Drawing.Size(1000, 200);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaThanhPho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenThanhPho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_QuocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ThanhPho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_MaThanhPho;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_TenThanhPho;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton Btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_QuocGia;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grd_ThanhPho;

    }
}
