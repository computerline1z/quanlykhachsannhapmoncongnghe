namespace QLKS.PL.CMS.Login
{
    partial class LoginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.footer1 = new QLKS.PL.CMS.Login.Footer();
            this.loginForm1 = new QLKS.PL.CMS.Login.LoginForm();
            this.content1 = new QLKS.PL.CMS.Login.Content();
            this.header1 = new QLKS.PL.CMS.Login.Header();
            this.SuspendLayout();
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.Transparent;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 554);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1278, 130);
            this.footer1.TabIndex = 3;
            this.footer1.TabStop = false;
            // 
            // loginForm1
            // 
            this.loginForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loginForm1.BackColor = System.Drawing.Color.Transparent;
            this.loginForm1.Location = new System.Drawing.Point(3, 454);
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Size = new System.Drawing.Size(1275, 72);
            this.loginForm1.TabIndex = 2;
            // 
            // content1
            // 
            this.content1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.content1.BackColor = System.Drawing.Color.Transparent;
            this.content1.Location = new System.Drawing.Point(3, 69);
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(1278, 390);
            this.content1.TabIndex = 1;
            this.content1.TabStop = false;
            this.content1.Load += new System.EventHandler(this.content1_Load);
            // 
            // header1
            // 
            this.header1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.header1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.header1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header1.BackgroundImage")));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1278, 67);
            this.header1.TabIndex = 0;
            this.header1.TabStop = false;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKS.Properties.Resources.Background_index;
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.loginForm1);
            this.Controls.Add(this.content1);
            this.Controls.Add(this.header1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1278, 684);
            this.ResumeLayout(false);

        }

        #endregion

        private Header header1;
        private Content content1;
        private LoginForm loginForm1;
        private Footer footer1;
    }
}
