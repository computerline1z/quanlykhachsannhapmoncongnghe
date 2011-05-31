using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class LT_PHIEUTHUE
    {
        private string _MAPT;

        public string MAPT
        {
            get { return _MAPT; }
            set { _MAPT = value; }
        }
        private DateTime _NGAYBD;

        public DateTime NGAYBD
        {
            get { return _NGAYBD; }
            set { _NGAYBD = value; }
        }
        private DateTime _NGAYKT;

        public DateTime NGAYKT
        {
            get { return _NGAYKT; }
            set { _NGAYKT = value; }
        }
        private int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
        private int _TINHTRANG;

        public int TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
    }
}
