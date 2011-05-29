using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using System.Data;
using QLKS.BLL.Object;

namespace QLKS.BLL.BL
{
    public class LT_QUANBUS
    {
        public LT_QUANBUS() { }
        public static bool Insert(LT_QUAN tc)
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return dao.Insert(tc);
        }
        public static bool Update(LT_QUAN tc)
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return dao.Update(tc);
        }
        public static bool Delete(LT_QUAN tc)
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_QUAN tc)
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return dao.SelectByPK(tc);
        }
        public static DataTable SelectByTP(LT_QUAN tc)
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return dao.SelectByTP(tc);
        }
        public static string GetID()
        {
            LT_QUANDAO dao = new LT_QUANDAO();
            return "QU" + dao.GetID().ToString();
        }
    }
}
