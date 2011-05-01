using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class Sys_GroupsAuthorizationCollection : List<Sys_GroupsAuthorization>
    { }
    public class Sys_GroupsAuthorization
    {
        private Guid _GROUPID;

        public virtual Guid GROUPID
        {
            get { return _GROUPID; }
            set { _GROUPID = value; }
        }
        private Guid _AUTHORRIZATIONID;

        public virtual Guid AUTHORRIZATIONID
        {
            get { return _AUTHORRIZATIONID; }
            set { _AUTHORRIZATIONID = value; }
        }
        private Sys_Groups _Groups;

        public virtual Sys_Groups Groups
        {
            get { return _Groups; }
            set { _Groups = value; }
        }
        private Sys_Authorization _Authorization;

        public virtual Sys_Authorization Authorization
        {
            get { return _Authorization; }
            set { _Authorization = value; }
        }
        public Sys_GroupsAuthorization()
        {
            _GROUPID = new Guid();
            _AUTHORRIZATIONID = new Guid();
            _Groups = null;
            _Authorization = null;
        }
        public Sys_GroupsAuthorization(Guid GroupID, Guid Authorization)
        {
            _GROUPID = GroupID;
            _AUTHORRIZATIONID = Authorization;
        }
    }
}
