using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
namespace QLKS.BLL.BL
{
    public class SecurityManager
    {
        private static Sys_AuthorizationBUS au;
        private static bool _IsDebugMode = false;

        public static bool IsDebugMode
        {
            get { return SecurityManager._IsDebugMode; }
            set { SecurityManager._IsDebugMode = value; }
        }
        private static StringCollection AssembliesToVerify
        {
            get
            {
                Hashtable hast = (Hashtable)ConfigurationManager.GetSection("Security");
                StringCollection co = new StringCollection();
                foreach (string key in hast.Keys)
                {
                    if(bool.Parse(hast[key].ToString()))
                        co.Add(key);
                }
                return co;
            }
        }
        public static bool CheckAllAssemblies()
        {
            //DbAccess db = new DbAccess();
            return true;
        }
        //public static bool 
    }
}
