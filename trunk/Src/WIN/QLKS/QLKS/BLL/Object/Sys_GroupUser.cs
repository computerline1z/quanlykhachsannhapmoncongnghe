using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_GroupUserCollection : List<Sys_GroupUser>
    { }
    public class Sys_GroupUser
    {
        private Guid _GROUPID;
        public virtual Guid GROUPID
        {
            get { return _GROUPID; }
            set { _GROUPID = value; }
        }
        private string _LOGINID;
        public virtual string LOGINID
        {
            get { return _LOGINID; }
            set { _LOGINID = value; }
        }
        public Sys_GroupUser()
        {
            _GROUPID = new Guid();
            _LOGINID = string.Empty;
        }
        public Sys_GroupUser(Guid Groupid, string loginid)
        {
            _GROUPID = Groupid;
            _LOGINID = loginid;
        }
    }
}
