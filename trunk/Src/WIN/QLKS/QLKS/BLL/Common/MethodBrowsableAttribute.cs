using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Common
{
    [Serializable]
    public class MethodBrowsableAttribute:System.Attribute
    {
        private bool _Browsable;

        public bool Browsable
        {
            get { return _Browsable; }
        }
        public MethodBrowsableAttribute() { }
        public MethodBrowsableAttribute(bool browsable)
        {
            this._Browsable = browsable;
        }
    }
}
