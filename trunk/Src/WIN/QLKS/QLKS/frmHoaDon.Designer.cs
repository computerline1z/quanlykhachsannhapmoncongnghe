namespace QLKS
{
    partial class frmHoaDon
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
            this.ucHoaDon1 = new QLKS.PL.CMS.HoaDon.ucHoaDon();
            this.SuspendLayout();
            // 
            // ucHoaDon1
            // 
            this.ucHoaDon1.BackColor = System.Drawing.Color.Transparent;
            this.ucHoaDon1.Location = new System.Drawing.Point(4, -18);
            this.ucHoaDon1.Name = "ucHoaDon1";
            this.ucHoaDon1.Size = new System.Drawing.Size(1000, 788);
            this.ucHoaDon1.TabIndex = 0;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.ucHoaDon1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.PL.CMS.HoaDon.ucHoaDon ucHoaDon1;
    }
}