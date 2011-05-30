namespace QLKS
{
    partial class frmcauhinhketnoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcauhinhketnoi));
            this.btnconnect = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbdatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbserver = new System.Windows.Forms.ComboBox();
            this.btnseach = new DevExpress.XtraEditors.SimpleButton();
            this.rdwin = new System.Windows.Forms.RadioButton();
            this.rdsql = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSyncStatus = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnconnect
            // 
            this.btnconnect.ImageIndex = 5;
            this.btnconnect.ImageList = this.imageList1;
            this.btnconnect.Location = new System.Drawing.Point(272, 137);
            this.btnconnect.LookAndFeel.SkinName = "Blue";
            this.btnconnect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(82, 25);
            this.btnconnect.TabIndex = 5;
            this.btnconnect.Text = "Connect";
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.ico");
            this.imageList1.Images.SetKeyName(1, "xmag.ico");
            this.imageList1.Images.SetKeyName(2, "ok.ico");
            this.imageList1.Images.SetKeyName(3, "button_cancel.ico");
            this.imageList1.Images.SetKeyName(4, "save_all.ico");
            this.imageList1.Images.SetKeyName(5, "refresh.ico");
            // 
            // cmbdatabase
            // 
            this.cmbdatabase.Enabled = false;
            this.cmbdatabase.FormattingEnabled = true;
            this.cmbdatabase.Location = new System.Drawing.Point(119, 19);
            this.cmbdatabase.Name = "cmbdatabase";
            this.cmbdatabase.Size = new System.Drawing.Size(235, 21);
            this.cmbdatabase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSyncStatus);
            this.groupBox2.Controls.Add(this.rdsql);
            this.groupBox2.Controls.Add(this.rdwin);
            this.groupBox2.Controls.Add(this.btnconnect);
            this.groupBox2.Controls.Add(this.txtpass);
            this.groupBox2.Controls.Add(this.txtuser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đăng nhập ";
            // 
            // txtpass
            // 
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(119, 111);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(235, 20);
            this.txtpass.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(119, 86);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(235, 20);
            this.txtuser.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên tài khoản :";
            // 
            // btnluu
            // 
            this.btnluu.ImageIndex = 4;
            this.btnluu.ImageList = this.imageList1;
            this.btnluu.Location = new System.Drawing.Point(229, 325);
            this.btnluu.LookAndFeel.SkinName = "Blue";
            this.btnluu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(71, 25);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageIndex = 3;
            this.btnthoat.ImageList = this.imageList1;
            this.btnthoat.Location = new System.Drawing.Point(307, 325);
            this.btnthoat.LookAndFeel.SkinName = "Blue";
            this.btnthoat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(71, 25);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(49, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbserver
            // 
            this.cmbserver.FormattingEnabled = true;
            this.cmbserver.Location = new System.Drawing.Point(131, 16);
            this.cmbserver.Name = "cmbserver";
            this.cmbserver.Size = new System.Drawing.Size(235, 21);
            this.cmbserver.TabIndex = 3;
            this.cmbserver.SelectedIndexChanged += new System.EventHandler(this.cmbserver_SelectedIndexChanged);
            // 
            // btnseach
            // 
            this.btnseach.ImageIndex = 1;
            this.btnseach.ImageList = this.imageList1;
            this.btnseach.Location = new System.Drawing.Point(291, 42);
            this.btnseach.LookAndFeel.SkinName = "Blue";
            this.btnseach.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(75, 25);
            this.btnseach.TabIndex = 4;
            this.btnseach.Text = "Tìm kiếm";
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // rdwin
            // 
            this.rdwin.AutoSize = true;
            this.rdwin.Checked = true;
            this.rdwin.Location = new System.Drawing.Point(33, 27);
            this.rdwin.Name = "rdwin";
            this.rdwin.Size = new System.Drawing.Size(162, 17);
            this.rdwin.TabIndex = 6;
            this.rdwin.TabStop = true;
            this.rdwin.Text = "Use Windows Authentication";
            this.rdwin.UseVisualStyleBackColor = true;
            this.rdwin.CheckedChanged += new System.EventHandler(this.rdwin_CheckedChanged);
            // 
            // rdsql
            // 
            this.rdsql.AutoSize = true;
            this.rdsql.Location = new System.Drawing.Point(33, 53);
            this.rdsql.Name = "rdsql";
            this.rdsql.Size = new System.Drawing.Size(167, 17);
            this.rdsql.TabIndex = 7;
            this.rdsql.Text = "Use Sql Server Authentication";
            this.rdsql.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbdatabase);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Database :";
            // 
            // lblSyncStatus
            // 
            this.lblSyncStatus.BackColor = System.Drawing.Color.Cyan;
            this.lblSyncStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSyncStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyncStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblSyncStatus.Image")));
            this.lblSyncStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSyncStatus.Location = new System.Drawing.Point(75, 91);
            this.lblSyncStatus.Name = "lblSyncStatus";
            this.lblSyncStatus.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSyncStatus.Size = new System.Drawing.Size(270, 21);
            this.lblSyncStatus.TabIndex = 17;
            this.lblSyncStatus.Text = "Đang tìm kiếm Server Vui  lòng đợi ....";
            this.lblSyncStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmcauhinhketnoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnseach);
            this.Controls.Add(this.cmbserver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcauhinhketnoi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình kết nối";
            this.Load += new System.EventHandler(this.frmcauhinhketnoi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbdatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbserver;
        private DevExpress.XtraEditors.SimpleButton btnseach;
        private System.Windows.Forms.RadioButton rdsql;
        private System.Windows.Forms.RadioButton rdwin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSyncStatus;
    }
}