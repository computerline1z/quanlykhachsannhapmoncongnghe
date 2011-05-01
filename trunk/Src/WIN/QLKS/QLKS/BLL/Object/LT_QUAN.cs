using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    class LT_QUAN
    {
        private string _MAQUAN;

        public string MAQUAN
        {
            get { return _MAQUAN; }
            set { _MAQUAN = value; }
        }
        private string _TENQUAN;

        public string TENQUAN
        {
            get { return _TENQUAN; }
            set { _TENQUAN = value; }
        }
        private string _MATP;

        public string MATP
        {
            get { return _MATP; }
            set { _MATP = value; }
        }
    }
}
