using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ModuleDALCore;
namespace QLKS.DAL.Core
{
    public class DALBase
    {
        public DALBase()
        { }
        public void OpenConnect()
        {
            string _Server = ConfigurationSettings.AppSettings["Server"].ToString();
            string _Db = ConfigurationSettings.AppSettings["dbname"].ToString();
            string _user = ConfigurationSettings.AppSettings["username"].ToString();
            string _pass = ConfigurationSettings.AppSettings["password"].ToString();
            DBManager.Initialize(ProviderType.SqlServer, CreateConnectionString(_Server, _Db, _user, _pass));
        }
        private string CreateConnectionString(string Server, string Database, string User, string Pass)
        {
            mahoa.mahoa mh = new mahoa.mahoa();
            string server = mh.mahoadulieu(Server, false, "aeriscute");
            string data = mh.mahoadulieu(Database, true, "aeriscute");
            string user = mh.mahoadulieu(User, true, "aeriscute");
            string pass = mh.mahoadulieu(Pass, true, "aeriscute");
            if (String.IsNullOrEmpty(User) && String.IsNullOrEmpty(Pass))
                return "Server=" + server + ";" + "Database=" + data + ";" + "Integrated Security=SSPI";
            else
                return "Server=" + server + ";" + "Initial Catalog=" + data + ";" + "Persist Security Info=True;" + "User ID=" + user + ";" + "Password=" + pass;
               
        }
    }
}
