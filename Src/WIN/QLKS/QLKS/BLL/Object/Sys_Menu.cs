using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_MenuCollection : List<Sys_Menu>
    { }
    public class Sys_Menu
    {
        private string _MENUID;

        public virtual string MENUID
        {
            get { return _MENUID; }
            set { _MENUID = value; }
        }
        private int _MENUPOSITION;

        public virtual int MENUPOSITION
        {
            get { return _MENUPOSITION; }
            set { _MENUPOSITION = value; }
        }
        private string _MENUVALUE;

        public virtual string MENUVALUE
        {
            get { return _MENUVALUE; }
            set { _MENUVALUE = value; }
        }
        private string _MENUFILIATIONID;

        public virtual string MENUFILIATIONID
        {
            get { return _MENUFILIATIONID; }
            set { _MENUFILIATIONID = value; }
        }
        private string _FORMNAME;

        public virtual string FORMNAME
        {
            get { return _FORMNAME; }
            set { _FORMNAME = value; }
        }
        public Sys_Menu()
        {
            _MENUID = string.Empty;
            _MENUPOSITION = 0;
            _MENUVALUE = string.Empty;
            _MENUFILIATIONID = string.Empty;
            _FORMNAME = string.Empty;
        }
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            Sys_Menu castObj = (Sys_Menu)obj;
            return (castObj != null) &&
                (this._MENUID == castObj.MENUID);
        }
        public override int GetHashCode()
        {
            int hash = 57;
            hash = 27 * hash * _MENUID.GetHashCode();
            return hash;
        }
    }
}
