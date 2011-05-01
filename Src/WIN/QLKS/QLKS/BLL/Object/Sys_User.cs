using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public enum UserStatus
    {
        OK = 1,
        Locked = 2,
        ExpiredDate = 3,
        NotExists = 4
    }
    public class Sys_UserCollection : List<Sys_User>
    { }
    public class Sys_User
    {
        private string _LOGINID;

        public virtual string LOGINID
        {
            get { return _LOGINID; }
            set { _LOGINID = value; }
        }
        private string _PASSWORD;

        public virtual string PASSWORD
        {
            get { return _PASSWORD; }
            set { _PASSWORD = value; }
        }
        private string _MANV;

        public virtual string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        private string _EMAIL;

        public virtual string EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }
        private DateTime _CREATEDATE;

        public virtual DateTime CREATEDATE
        {
            get { return _CREATEDATE; }
            set { _CREATEDATE = value; }
        }
        private bool _LOCKUSER;

        public virtual bool LOCKUSER
        {
            get { return _LOCKUSER; }
            set { _LOCKUSER = value; }
        }
        private DateTime _LOCKDATE;

        public virtual DateTime LOCKDATE
        {
            get { return _LOCKDATE; }
            set { _LOCKDATE = value; }
        }
        private string _LOCKEDREASON;

        public virtual string LOCKEDREASON
        {
            get { return _LOCKEDREASON; }
            set { _LOCKEDREASON = value; }
        }
        private DateTime _LASTLOGIN;

        public virtual DateTime LASTLOGIN
        {
            get { return _LASTLOGIN; }
            set { _LASTLOGIN = value; }
        }
        private DateTime _LASTCHANGEPASSWORD;

        public virtual DateTime LASTCHANGEPASSWORD
        {
            get { return LASTCHANGEPASSWORD; }
            set { LASTCHANGEPASSWORD = value; }
        }
        private DateTime _DEADLINEOFUSING;

        public virtual DateTime DEADLINEOFUSING
        {
            get { return DEADLINEOFUSING; }
            set { DEADLINEOFUSING = value; }
        }
        public Sys_User()
        {
            _LOGINID = string.Empty;
            _PASSWORD = string.Empty;
            _MANV = string.Empty;
            _EMAIL = string.Empty;

            DateTime dtmDefault = new DateTime(1900, 1, 1);
            _CREATEDATE = dtmDefault;
            _LOCKUSER = false;
            _LOCKDATE = dtmDefault;
            _LOCKEDREASON = string.Empty;
            _LASTLOGIN = dtmDefault;
            _LASTCHANGEPASSWORD = dtmDefault;
            _DEADLINEOFUSING = dtmDefault;
        }
    }
}
