using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using QLKS.BLL.Object;
using System.Data;

namespace QLKS.BLL.BL
{
   public class LT_THANHPHOBUS
    {
       public LT_THANHPHOBUS() { }
        public static bool Insert(LT_THANHPHO tp)
        {
            LT_THANHPHODAO dao = new LT_THANHPHODAO();
            return dao.Insert(tp);
        }
        public static bool Update(LT_THANHPHO tp)
        {
            LT_THANHPHODAO dao = new LT_THANHPHODAO();
            return dao.Update(tp);
        }
        public static bool Delete(LT_THANHPHO tp)
        {
            LT_THANHPHODAO dao = new LT_THANHPHODAO();
            return dao.Delete(tp);
        }
        public static DataTable SelectAll()
        {
            LT_THANHPHODAO dao = new LT_THANHPHODAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_THANHPHO tp)
        {
            LT_THANHPHODAO dao = new LT_THANHPHODAO();
            return dao.SelectByPK(tp);
        }
        public static string GetID()
        {
            LT_THANHPHODAO dao = new LT_THANHPHODAO();
            return "TP" + dao.GetID().ToString();
        }
    }
}
