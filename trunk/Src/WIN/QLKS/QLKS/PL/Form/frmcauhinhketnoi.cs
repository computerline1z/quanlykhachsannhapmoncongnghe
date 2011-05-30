using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.SqlServer.Management.Smo;
using System.Threading;
using Microsoft.SqlServer.Management.Common;
using Hopthoai;
using QLKS.DAL.Core;
namespace QLKS
{
    public partial class frmcauhinhketnoi : Form
    {
        DataTable dt;
        ServerConnection m_ServerConnection;
        Server server;
        EventHandler _Handler;
        frmHoidap f;
        mahoa.mahoa mh;
        public frmcauhinhketnoi()
        {
            InitializeComponent();
        }
        public Server DatabaseServer
        {
            get { return this.server; }
        }
        private void btnseach_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dtServers = SmoApplication.EnumAvailableSqlServers(false);
            this.cmbserver.DataSource = dtServers;
            this.cmbserver.DisplayMember = "Name";
            this.cmbserver.ValueMember = "Name";
            this.Cursor = Cursors.Default;
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
        private void frmcauhinhketnoi_Load(object sender, EventArgs e)
        {
            this.rdwin.Checked = true;
            
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
            string ser=ConfigSettings.ReadSetting("server"); 
            string serverstring=mh.mahoadulieu(ser,false,"aeriscute");
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
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            mahoa.mahoa mh = new mahoa.mahoa();
            ConfigSettings.WriteSetting("server", mh.mahoadulieu( cmbserver.Text.ToString(),true,"aeriscute"));
            ConfigSettings.WriteSetting("dbname", mh.mahoadulieu(cmbdatabase.Text.ToString(), true, "aeriscute"));
            ConfigSettings.WriteSetting("username",mh.mahoadulieu( txtuser.Text,true,"aeriscute"));
            ConfigSettings.WriteSetting("password",mh.mahoadulieu( txtpass.Text,true,"aeriscute"));
            System.Windows.Forms.Application.Restart();

        }
        private void rdsql_CheckedChanged(object sender, EventArgs e)
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
        private void rdwin_CheckedChanged(object sender, EventArgs e)
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
        private void cmbserver_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbdatabase.Items.Clear();
        }
    }
}
