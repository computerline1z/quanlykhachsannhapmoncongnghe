namespace QLKS
{
    partial class frmDatPhong
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
            this.ucDatPhong1 = new QLKS.PL.CMS.DatPhong.UcDatPhong();
            this.SuspendLayout();
            // 
            // ucDatPhong1
            // 
            this.ucDatPhong1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucDatPhong1.BackColor = System.Drawing.Color.AliceBlue;
            this.ucDatPhong1.Location = new System.Drawing.Point(0, -3);
            this.ucDatPhong1.Name = "ucDatPhong1";
            this.ucDatPhong1.Size = new System.Drawing.Size(900, 556);
            this.ucDatPhong1.TabIndex = 0;
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(900, 557);
            this.Controls.Add(this.ucDatPhong1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.PL.CMS.DatPhong.UcDatPhong ucDatPhong1;


    }
}