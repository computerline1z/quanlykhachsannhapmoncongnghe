using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    class LT_LOAIPHONG
    {
        private string _MALPHG;

        public string MALPHG
        {
            get { return _MALPHG; }
            set { _MALPHG = value; }
        }
        private string _TENLPHG;

        public string TENLPHG
        {
            get { return _TENLPHG; }
            set { _TENLPHG = value; }
        }
        private int _DONGIA;

        public int DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }
        private string _GHICHU;

        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
    }
}
