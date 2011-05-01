using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_GroupsCollection : List<Sys_Groups>
    { 
    }
    public class Sys_Groups
    {
        private string _GROUPID;

        public virtual string GROUPID
        {
            get { return _GROUPID; }
            set { _GROUPID = value; }
        }
        private string _GROUPNAME;

        public virtual string GROUPNAME
        {
            get { return _GROUPNAME; }
            set { _GROUPNAME = value; }
        }
        private  string _NOTE;

        public virtual string NOTE
        {
            get { return _NOTE; }
            set { _NOTE = value; }
        }
        private bool _ISADMIN;

        public virtual bool ISADMIN
        {
            get { return _ISADMIN; }
            set { _ISADMIN = value; }
        }
    }
}
