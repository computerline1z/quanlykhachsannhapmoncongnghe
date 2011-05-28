using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Object
{
    public class LT_QUOCGIA
    {
        #region ***** Fields & Properties *****
        private string _MAQG;
        public string MAQG
        {
            get
            {
                return _MAQG;
            }
            set
            {
                _MAQG = value;
            }
        }
        private string _TENQG;
        public string TENQG
        {
            get
            {
                return _TENQG;
            }
            set
            {
                _TENQG = value;
            }
        }
        #endregion

        #region ***** Init Methods *****
        public LT_QUOCGIA()
        {
        }
        public LT_QUOCGIA(string maqg)
        {
            this.MAQG = maqg;
        }
        public LT_QUOCGIA(string maqg, string tenqg)
        {
            this.MAQG = maqg;
            this.TENQG = tenqg;
        }
        #endregion
    }

}
