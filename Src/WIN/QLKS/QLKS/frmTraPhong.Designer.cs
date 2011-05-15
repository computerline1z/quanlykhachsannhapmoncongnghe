namespace QLKS
{
    partial class frmTraPhong
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
            this.ucTraPhong1 = new QLKS.PL.CMS.TraPhong.ucTraPhong();
            this.SuspendLayout();
            // 
            // ucTraPhong1
            // 
            this.ucTraPhong1.BackColor = System.Drawing.Color.Transparent;
            this.ucTraPhong1.Location = new System.Drawing.Point(12, 12);
            this.ucTraPhong1.Name = "ucTraPhong1";
            this.ucTraPhong1.Size = new System.Drawing.Size(973, 689);
            this.ucTraPhong1.TabIndex = 0;
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.ucTraPhong1);
            this.Name = "frmTraPhong";
            this.Text = "frmTraPhong";
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.PL.CMS.TraPhong.ucTraPhong ucTraPhong1;
    }
}