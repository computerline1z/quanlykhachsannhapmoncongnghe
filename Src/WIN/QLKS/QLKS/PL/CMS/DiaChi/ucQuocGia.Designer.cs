namespace QLKS.PL.CMS.DiaChi
{
    partial class ucQuocGia
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_QuocGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaQG = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenQG = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_QuocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaQG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenQG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Xoa);
            this.groupControl1.Controls.Add(this.Btn_Sua);
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.txt_TenQG);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_MaQG);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(7, 145);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 72);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Quốc Gia";
            // 
            // grd_QuocGia
            // 
            this.grd_QuocGia.Location = new System.Drawing.Point(7, 3);
            this.grd_QuocGia.MainView = this.gridView1;
            this.grd_QuocGia.Name = "grd_QuocGia";
            this.grd_QuocGia.Size = new System.Drawing.Size(990, 136);
            this.grd_QuocGia.TabIndex = 1;
            this.grd_QuocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_QuocGia;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Quốc Gia:";
            // 
            // txt_MaQG
            // 
            this.txt_MaQG.Location = new System.Drawing.Point(103, 25);
            this.txt_MaQG.Name = "txt_MaQG";
            this.txt_MaQG.Size = new System.Drawing.Size(132, 20);
            this.txt_MaQG.TabIndex = 1;
            // 
            // txt_TenQG
            // 
            this.txt_TenQG.Location = new System.Drawing.Point(396, 25);
            this.txt_TenQG.Name = "txt_TenQG";
            this.txt_TenQG.Size = new System.Drawing.Size(132, 20);
            this.txt_TenQG.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(309, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Quốc Gia:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(560, 28);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Location = new System.Drawing.Point(659, 28);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(85, 23);
            this.Btn_Sua.TabIndex = 5;
            this.Btn_Sua.Text = "Sửa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(767, 28);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 23);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            // 
            // ucQuocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grd_QuocGia);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucQuocGia";
            this.Size = new System.Drawing.Size(1000, 220);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_QuocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaQG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenQG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_QuocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_MaQG;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenQG;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton Btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
    }
}
