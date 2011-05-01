using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    class LT_QUOCGIA
    {
        LT_QUOCGIA() { }
        private string _MAQG;
        private string _TENQG;
        public string MAQG
        {
            get { return _MAQG; }
            set { _MAQG = value; }
        }
        public string TENQG
        {
            get { return _TENQG; }
            set { _TENQG = value; }
        }
        ~LT_QUOCGIA() { }
    }
}
