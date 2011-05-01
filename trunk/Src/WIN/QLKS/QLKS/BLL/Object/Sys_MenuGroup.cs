using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_MenuGroupCollection : List<Sys_MenuGroup>
    { }
    public class Sys_MenuGroup
    {
        private Guid _GROUPID;
        public virtual Guid GROUPID
        {
            get { return _GROUPID; }
            set { _GROUPID = value; }
        }
        private string _MENUID;
        public virtual string MENUID
        {
            get { return _MENUID; }
            set { _MENUID = value; }
        }
        public Sys_MenuGroup()
        {
            _GROUPID = new Guid();
            _MENUID = string.Empty;
        }
    }
}
