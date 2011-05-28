using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
   public class LT_PHONG
    {
        private string _MAPHG;

        public string MAPHG
        {
            get { return _MAPHG; }
            set { _MAPHG = value; }
        }
        private string _TENPHG;

        public string TENPHG
        {
            get { return _TENPHG; }
            set { _TENPHG = value; }
        }
        private int _TINHTRANG;

        public int TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private string _MALPHG;

        public string MALPHG
        {
            get { return _MALPHG; }
            set { _MALPHG = value; }
        }
    }
}
