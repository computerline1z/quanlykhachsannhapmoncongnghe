using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using QLKS.BLL.Object;
using System.Data;

namespace QLKS.BLL.BL
{
   public class LT_LOAIKHBUS
    {
       public LT_LOAIKHBUS() { }
        public static bool Insert(LT_LOAIKH tc)
        {
            LT_LOAIKHDAO dao = new LT_LOAIKHDAO();
            return dao.Insert(tc);
        }
        public static bool Update(LT_LOAIKH tc)
        {
            LT_LOAIKHDAO dao = new LT_LOAIKHDAO();
            return dao.Update(tc);
        }
        public static bool Delete(LT_LOAIKH tc)
        {
            LT_LOAIKHDAO dao = new LT_LOAIKHDAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            LT_LOAIKHDAO dao = new LT_LOAIKHDAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_LOAIKH tc)
        {
            LT_LOAIKHDAO dao = new LT_LOAIKHDAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            LT_LOAIKHDAO dao = new LT_LOAIKHDAO();
            return "LKH" + dao.GetID().ToString();
        }
    }
}
