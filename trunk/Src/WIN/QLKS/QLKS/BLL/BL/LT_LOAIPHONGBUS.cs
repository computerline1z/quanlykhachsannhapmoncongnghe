using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using QLKS.BLL.Object;
using System.Data;

namespace QLKS.BLL.BL
{
    public class LT_LOAIPHONGBUS
    {
        public LT_LOAIPHONGBUS() { }
        public static bool Insert(LT_LOAIPHONG tc)
        {
            LT_LOAIPHONGDAO dao = new LT_LOAIPHONGDAO();
            return dao.Insert(tc);
        }
        public static bool Update(LT_LOAIPHONG tc)
        {
            LT_LOAIPHONGDAO dao = new LT_LOAIPHONGDAO();
            return dao.Update(tc);
        }
        public static bool Delete(LT_LOAIPHONG tc)
        {
            LT_LOAIPHONGDAO dao = new LT_LOAIPHONGDAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            LT_LOAIPHONGDAO dao = new LT_LOAIPHONGDAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_LOAIPHONG tc)
        {
            LT_LOAIPHONGDAO dao = new LT_LOAIPHONGDAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            LT_LOAIPHONGDAO dao = new LT_LOAIPHONGDAO();
            return "LPH" + dao.GetID().ToString();
        }
    }
}
