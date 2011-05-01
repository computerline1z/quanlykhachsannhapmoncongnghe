using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_AuthorizationCollection : List<Sys_Authorization>
    { 
    }
    public class Sys_Authorization
    {
        Sys_Authorization()
        {
            _AUTHORRIZATIONID = new Guid();
            _TITLE = string.Empty;
            _DESCRIPTION = string.Empty;
            _METHODFULLNAME = string.Empty;
            _MODULEID = -1;
        }
        private  Guid _AUTHORRIZATIONID;
        public virtual Guid AUTHORRIZATIONID
        {
            get { return _AUTHORRIZATIONID; }
            set { _AUTHORRIZATIONID = value; }
        }
        private string _TITLE;

        public virtual string TITLE
        {
            get { return _TITLE; }
            set { _TITLE = value; }
        }
        private string _DESCRIPTION;

        public virtual string DESCRIPTION
        {
            get { return _DESCRIPTION; }
            set { _DESCRIPTION = value; }
        }
        private string _METHODFULLNAME;

        public virtual string METHODFULLNAME
        {
            get { return _METHODFULLNAME; }
            set { _METHODFULLNAME = value; }
        }
        private int _MODULEID;

        public virtual int MODULEID
        {
            get { return _MODULEID; }
            set { _MODULEID = value; }
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || (obj.GetType() != this.GetType()))
                return false;
            Sys_Authorization cast = (Sys_Authorization)obj;
            return (cast != null) && (this._AUTHORRIZATIONID == cast.AUTHORRIZATIONID);
        }
        public override int GetHashCode()
        {
            int hast = 57;
            hast = 27 * hast * _AUTHORRIZATIONID.GetHashCode();
            return hast;
        }
    }
}
