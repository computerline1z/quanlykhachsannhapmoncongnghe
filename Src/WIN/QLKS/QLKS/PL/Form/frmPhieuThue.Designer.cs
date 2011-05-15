namespace QLKS.PL.CMS.PhieuThue
{
    partial class frmPhieuThue
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
            this.ucPhieuThue1 = new QLKS.PL.CMS.PhieuThue.ucPhieuThue();
            this.SuspendLayout();
            // 
            // ucPhieuThue1
            // 
            this.ucPhieuThue1.BackColor = System.Drawing.Color.Transparent;
            this.ucPhieuThue1.Location = new System.Drawing.Point(4, -16);
            this.ucPhieuThue1.Name = "ucPhieuThue1";
            this.ucPhieuThue1.Size = new System.Drawing.Size(1000, 750);
            this.ucPhieuThue1.TabIndex = 0;
            // 
            // frmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.ucPhieuThue1);
            this.Name = "frmPhieuThue";
            this.Text = "PhieuThue";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPhieuThue ucPhieuThue1;
    }
}