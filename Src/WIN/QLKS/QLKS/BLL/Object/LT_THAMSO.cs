using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class LT_THAMSO
    {
        private string _MATS;

        public string MATS
        {
            get { return _MATS; }
            set { _MATS = value; }
        }
        private string _TENTS;

        public string TENTS
        {
            get { return _TENTS; }
            set { _TENTS = value; }
        }
        private float _HESO;

        public float HESO
        {
            get { return _HESO; }
            set { _HESO = value; }
        }
        private bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
    }
}
