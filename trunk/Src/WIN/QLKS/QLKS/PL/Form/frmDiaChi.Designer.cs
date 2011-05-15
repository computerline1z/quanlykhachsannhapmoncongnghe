namespace QLKS.PL.CMS.DiaChi
{
    partial class frmDiaChi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ucQuocGia1 = new QLKS.PL.CMS.DiaChi.ucQuocGia();
            this.ucThanhPho1 = new QLKS.PL.CMS.DiaChi.ucThanhPho();
            this.uc_Quan1 = new QLKS.PL.CMS.DiaChi.uc_Quan();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucQuocGia1);
            this.groupControl1.Location = new System.Drawing.Point(5, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1005, 240);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Quốc Gia";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ucThanhPho1);
            this.groupControl2.Location = new System.Drawing.Point(6, 247);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1005, 240);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Thành Phố";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.uc_Quan1);
            this.groupControl3.Location = new System.Drawing.Point(7, 490);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1005, 240);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Quận";
            // 
            // ucQuocGia1
            // 
            this.ucQuocGia1.BackColor = System.Drawing.Color.Transparent;
            this.ucQuocGia1.Location = new System.Drawing.Point(0, 19);
            this.ucQuocGia1.Name = "ucQuocGia1";
            this.ucQuocGia1.Size = new System.Drawing.Size(1000, 220);
            this.ucQuocGia1.TabIndex = 0;
            // 
            // ucThanhPho1
            // 
            this.ucThanhPho1.BackColor = System.Drawing.Color.Transparent;
            this.ucThanhPho1.Location = new System.Drawing.Point(6, 22);
            this.ucThanhPho1.Name = "ucThanhPho1";
            this.ucThanhPho1.Size = new System.Drawing.Size(1000, 200);
            this.ucThanhPho1.TabIndex = 0;
            // 
            // uc_Quan1
            // 
            this.uc_Quan1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Quan1.Location = new System.Drawing.Point(-2, 25);
            this.uc_Quan1.Name = "uc_Quan1";
            this.uc_Quan1.Size = new System.Drawing.Size(1000, 200);
            this.uc_Quan1.TabIndex = 0;
            // 
            // frmDiaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDiaChi";
            this.Text = "frmDiaChi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ucQuocGia ucQuocGia1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ucThanhPho ucThanhPho1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private uc_Quan uc_Quan1;

    }
}