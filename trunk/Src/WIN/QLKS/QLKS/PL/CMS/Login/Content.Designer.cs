namespace QLKS.PL.CMS.Login
{
    partial class Content
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            this.flashaction = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.flashaction)).BeginInit();
            this.SuspendLayout();
            // 
            // flashaction
            // 
            this.flashaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flashaction.Enabled = true;
            this.flashaction.Location = new System.Drawing.Point(164, 0);
            this.flashaction.Name = "flashaction";
            this.flashaction.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashaction.OcxState")));
            this.flashaction.Size = new System.Drawing.Size(950, 387);
            this.flashaction.TabIndex = 0;
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flashaction);
            this.Name = "Content";
            this.Size = new System.Drawing.Size(1278, 390);
            this.Load += new System.EventHandler(this.Content_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flashaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash flashaction;
    }
}
