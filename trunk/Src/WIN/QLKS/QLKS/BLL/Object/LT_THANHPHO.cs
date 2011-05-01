using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    class LT_THANHPHO
    {
        private string _MATP;

        public string MATP
        {
            get { return _MATP; }
            set { _MATP = value; }
        }
        private string _TENTP;

        public string TENTP
        {
            get { return _TENTP; }
            set { _TENTP = value; }
        }
        private string _MAQG;

        public string MAQG
        {
            get { return _MAQG; }
            set { _MAQG = value; }
        }
    }
}
