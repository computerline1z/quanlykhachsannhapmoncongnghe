using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_MoDulesCollection : List<Sys_MoDules>
    { }
    public class Sys_MoDules
    {
        private int _MODULEID;

        public virtual int MODULEID
        {
            get { return _MODULEID; }
            set { _MODULEID = value; }
        }
        private string _MODULENAME;

        public virtual string MODULENAME
        {
            get { return _MODULENAME; }
            set { _MODULENAME = value; }
        }
        private string _NODE;

        public virtual string NODE
        {
            get { return _NODE; }
            set { _NODE = value; }
        }
        public Sys_MoDules()
        {
            _MODULEID = -1;
            _MODULENAME = string.Empty;
            _NODE = string.Empty;
        }
        public override int GetHashCode()
        {
            int hash = 57;
            hash = 27 * hash *_MODULEID.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            Sys_MoDules castObj = (Sys_MoDules)obj;
            return (castObj != null) &&
                (this._MODULEID == castObj.MODULEID);
        }
    }
}
