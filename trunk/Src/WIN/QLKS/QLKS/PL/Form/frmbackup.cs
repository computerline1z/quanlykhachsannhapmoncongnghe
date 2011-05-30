using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Hopthoai;
using Microsoft.SqlServer.Management.Common;
using QLKS.DAL.Core;

namespace QLKS
{
    public partial class frmbackup : Form
    {
        DataTable dt;
        ServerConnection m_ServerConnection;
       Server server;
        EventHandler _Handler;
        frmHoidap f;
        mahoa.mahoa mh;
        private string _Link;

        public string Link
        {
            get { return _Link; }
            set { _Link = value; }
        }
        private string _Tenform;

        public string Tenform
        {
            get { return _Tenform; }
            set { _Tenform = value; }
        }
        private int _flag;

        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        public frmbackup()
        {
            InitializeComponent();
        }
        private void SetTenForm()
        {
            this.Text = this.Tenform;
        }
        private void ListDatabasesInServer()
        {
            this.cmbdatabase.Items.Clear();
            foreach (Database db in this.server.Databases)
            {
                if (!db.IsSystemObject)
                {
                    this.cmbdatabase.Items.Add(db.Name);
                }
            }
            this.cmbdatabase.SelectedIndex = 0;
        }
        void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= this._Handler;

            dt = SmoApplication.EnumAvailableSqlServers(false);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            this.cmbserver.DataSource = dt;
            this.cmbserver.DisplayMember = "Name";
            this.cmbserver.ValueMember = "Name";

            //Set the default server
            mh = new mahoa.mahoa();
            string ser = ConfigSettings.ReadSetting("server");
            string serverstring = mh.mahoadulieu(ser, false, "aeriscute");
            if (!string.IsNullOrEmpty(serverstring))
            {
                this.cmbserver.SelectedIndex = dt.Rows.IndexOf(dt.Rows.Find(serverstring));
            }
            else
            {
                this.cmbserver.SelectedIndex = 0;
            }

            string tmpDbName = ConfigSettings.ReadSetting("dbname");
            string tmp = mh.mahoadulieu(tmpDbName, true, "aeriscute");
            if (!string.IsNullOrEmpty(tmp))
            {
                this.btnconnect_Click(this, null);
                this.cmbdatabase.SelectedItem = tmp;
            }
            this.lblSyncStatus.Visible = false;
            this.groupBox1.Enabled = true;

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.lblSyncStatus.Visible = true;
            this.lblSyncStatus.BringToFront();
            this.groupBox1.Enabled = false;
            this._Handler = new EventHandler(this.Application_Idle);
            Application.Idle += this._Handler;
        }
        private string ConnectDatabase()
        {
            if (!string.IsNullOrEmpty(this.cmbserver.Text))
            {
                try
                {
                    this.m_ServerConnection = new ServerConnection(this.cmbserver.Text.ToString());
                    //this.m_ServerConnection
                    //First Check type of Authentication
                    if (this.rdwin.Checked == true)   //Windows Authentication
                    {
                        this.m_ServerConnection.LoginSecure = true;
                        this.server = new Server(this.m_ServerConnection);
                    }
                    else
                    {
                        // Create a new connection to the selected server name
                        this.m_ServerConnection.LoginSecure = false;
                        this.m_ServerConnection.Login = this.txtuser.Text;       //Login User
                        this.m_ServerConnection.Password = this.txtpass.Text;    //Login Password
                        this.m_ServerConnection.DatabaseName = this.cmbdatabase.Text;  //Database Name
                        // Create a new SQL Server object using the connection we created
                        this.server = new Server(this.m_ServerConnection);
                    }
                    return string.Empty;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return "No server selected";
        }
        private void rdwin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.rdwin.Checked == true)
            {
                this.txtuser.Enabled = false;
                this.txtpass.Enabled = false;
            }
            else
            {
                this.txtuser.Enabled = true;
                this.txtpass.Enabled = true;
            }
        }

        private void rdsql_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.rdsql.Checked == true)
            {
                this.txtuser.Enabled = true;
                this.txtpass.Enabled = true;
            }
            else
            {
                this.txtuser.Enabled = false;
                this.txtpass.Enabled = false;
            }
        }

        private void cmbserver_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.cmbdatabase.Items.Clear();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (!string.IsNullOrEmpty(this.cmbserver.Text))
                {
                    string message = this.ConnectDatabase();
                    if (string.IsNullOrEmpty(message))
                    {
                        this.ListDatabasesInServer();
                    }
                    else
                    {
                        f = new frmHoidap(message, frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                        f.ShowDialog();
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    f = new frmHoidap("Vui lòng chọn tên Server trước!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                    f.ShowDialog();
                    return;
                }
                this.cmbdatabase.Enabled = true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "SQL Authetication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Cursor = Cursors.Default;
        }

        private void frmbackup_Load(object sender, EventArgs e)
        {
            this.rdwin.Checked = true;
            SetTenForm();
            if (this.Flag == 2)
                SetRetore();
        }
        void SetRetore()
        {
            this.txttenbackup.Enabled = false;
            this.txtmieuta.Enabled = false;
        }
        private void btnseach_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtServers = SmoApplication.EnumAvailableSqlServers(false);
                this.cmbserver.DataSource = dtServers;
                this.cmbserver.DisplayMember = "Name";
                this.cmbserver.ValueMember = "Name";
                this.Cursor = Cursors.Default;
            }
            catch { }
        }

        private void cmbdatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbdatabase.SelectedIndex != -1)
            {
                txttenbackup.Text = this.cmbdatabase.SelectedItem.ToString()+DateTime.Now.Day.ToString()+DateTime.Now.Month.ToString()+DateTime.Now.Year.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "Backup Files(*.GDT)|*.GDT|All files (*.*)|*.*";
                open.FileName = txttenbackup.Text;
                open.ShowDialog();
                if (!String.IsNullOrEmpty(open.FileName))
                {
                    Link = open.FileName;
                }
            }
            else
            {

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup Files(*.GDT)|*.GDT|All files (*.*)|*.*";
                open.FileName = txttenbackup.Text;
                open.ShowDialog();
                if (!String.IsNullOrEmpty(open.FileName))
                {
                    Link = open.FileName;
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (this.Flag == 1)//do backup
            {
                BackUp();
              
            }
            if (this.Flag == 2)//do retore
            {
                Restore();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                this.Close();

            }
            if (Flag == 2)
            {
                Application.Restart();
            }
        }
        private void BackUp()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                SQLDMO._SQLServer srv = new SQLDMO.SQLServerClass();
                if (rdwin.Checked == true)
                {
                    srv.LoginSecure = true;
                    srv.Connect(this.cmbserver.Text, "", "");
                }
                else
                {
                    srv.Connect(this.cmbserver.Text, this.txtuser.Text, this.txtpass.Text);
                }
              
                SQLDMO.Backup bak = new SQLDMO.BackupClass();
                bak.Devices = bak.Files;
                bak.Files = this.Link;
                bak.Database = this.cmbdatabase.Text;
                bak.BackupSetDescription = txtmieuta.Text ;
                bak.SQLBackup(srv);
                f = new frmHoidap("Sao lưu dữ liệu thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                f.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (Exception err)
            {
                this.Cursor = Cursors.Default;
                f = new frmHoidap(err.Message, frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
            }
        }
        private void Restore()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                SQLDMO._SQLServer srv = new SQLDMO.SQLServerClass();
                if (rdwin.Checked == true)
                {
                    srv.LoginSecure = true;
                    srv.Connect(this.cmbserver.Text, "", "");
                }
                else
                {
                    srv.Connect(this.cmbserver.Text, this.txtuser.Text, this.txtpass.Text);
                }
                SQLDMO.Restore res = new SQLDMO.RestoreClass();
                res.Devices = res.Files;
                res.Files = this.Link;
                res.Database = this.cmbdatabase.Text;
                res.ReplaceDatabase = true;
                res.SQLRestore(srv);
                f = new frmHoidap("phục hồi dữ liệu thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                f.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (Exception err)
            {
                this.Cursor = Cursors.Default;
                f = new frmHoidap(err.Message, frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
                f.ShowDialog();
            }
        }

        private void txtmieuta_Leave(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                if (String.IsNullOrEmpty(txtmieuta.Text))
                {
                    f = new frmHoidap("Không thể để trống dữ liệu miêu tả!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                    f.ShowDialog();
                    txtmieuta.Focus();
                }
            }
        }
       
    }
}
