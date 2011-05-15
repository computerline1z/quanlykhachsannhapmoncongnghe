namespace QLKS.PL.CMS.DiaChi
{
    partial class uc_Quan
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
            this.grd_Quan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbx_ThanhPho = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenQuan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaQuan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Quan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_ThanhPho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaQuan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Quan
            // 
            this.grd_Quan.Location = new System.Drawing.Point(5, 3);
            this.grd_Quan.MainView = this.gridView1;
            this.grd_Quan.Name = "grd_Quan";
            this.grd_Quan.Size = new System.Drawing.Size(990, 120);
            this.grd_Quan.TabIndex = 5;
            this.grd_Quan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_Quan;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbx_ThanhPho);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btn_Xoa);
            this.groupControl1.Controls.Add(this.Btn_Sua);
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.txt_TenQuan);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_MaQuan);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 125);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 72);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông Tin Quận";
            // 
            // cbx_ThanhPho
            // 
            this.cbx_ThanhPho.Location = new System.Drawing.Point(87, 31);
            this.cbx_ThanhPho.Name = "cbx_ThanhPho";
            this.cbx_ThanhPho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_ThanhPho.Size = new System.Drawing.Size(118, 20);
            this.cbx_ThanhPho.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Thành Phố:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(898, 28);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 23);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Location = new System.Drawing.Point(790, 28);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(85, 23);
            this.Btn_Sua.TabIndex = 5;
            this.Btn_Sua.Text = "Sửa";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(691, 28);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            // 
            // txt_TenQuan
            // 
            this.txt_TenQuan.Location = new System.Drawing.Point(537, 31);
            this.txt_TenQuan.Name = "txt_TenQuan";
            this.txt_TenQuan.Size = new System.Drawing.Size(132, 20);
            this.txt_TenQuan.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(450, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Quận:";
            // 
            // txt_MaQuan
            // 
            this.txt_MaQuan.Location = new System.Drawing.Point(309, 31);
            this.txt_MaQuan.Name = "txt_MaQuan";
            this.txt_MaQuan.Size = new System.Drawing.Size(132, 20);
            this.txt_MaQuan.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(222, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Quận:";
            // 
            // uc_Quan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grd_Quan);
            this.Controls.Add(this.groupControl1);
            this.Name = "uc_Quan";
            this.Size = new System.Drawing.Size(1000, 200);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Quan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_ThanhPho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaQuan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Quan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_ThanhPho;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton Btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_TenQuan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MaQuan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
