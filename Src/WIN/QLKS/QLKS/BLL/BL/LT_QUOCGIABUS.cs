using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.BLL.Object;
using QLKS.DAL.DAO;
using System.Data;

namespace QLKS.BLL.BL
{
    public class LT_QUOCGIABUS
    {
        public LT_QUOCGIABUS() { }
        public static bool Insert(LT_QUOCGIA tc)
        {
            LT_QUOCGIADAO dao = new LT_QUOCGIADAO();
            return dao.Insert(tc);
        }
        public static bool Update(LT_QUOCGIA tc)
        {
            LT_QUOCGIADAO dao = new LT_QUOCGIADAO();
            return dao.Update(tc);
        }
        public static bool Delete(LT_QUOCGIA tc)
        {
            LT_QUOCGIADAO dao = new LT_QUOCGIADAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            LT_QUOCGIADAO dao = new LT_QUOCGIADAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_QUOCGIA tc)
        {
            LT_QUOCGIADAO dao = new LT_QUOCGIADAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            LT_QUOCGIADAO dao = new LT_QUOCGIADAO();
            return "QG" + dao.GetID().ToString();
        }
    }
}
