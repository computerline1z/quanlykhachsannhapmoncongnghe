namespace QLKS.PL.CMS.KhachHang
{
    partial class frmKhachHang
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
            this.ucKhachHang1 = new QLKS.PL.CMS.KhachHang.ucKhachHang();
            this.SuspendLayout();
            // 
            // ucKhachHang1
            // 
            this.ucKhachHang1.BackColor = System.Drawing.Color.Transparent;
            this.ucKhachHang1.Location = new System.Drawing.Point(4, -17);
            this.ucKhachHang1.Name = "ucKhachHang1";
            this.ucKhachHang1.Size = new System.Drawing.Size(1000, 750);
            this.ucKhachHang1.TabIndex = 0;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.ucKhachHang1);
            this.Name = "frmKhachHang";
            this.ShowInTaskbar = false;
            this.Text = "Quản Lý Khách Hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private ucKhachHang ucKhachHang1;
    }
}