using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.BLL.Object;
using QLKS.DAL.DAO;
using System.Data;

namespace QLKS.BLL.BL
{
    public class LT_THAMSOBUS
    {
        public LT_THAMSOBUS() { }
        public static bool Insert(LT_THAMSO tc)
        {
            LT_THAMSODAO dao = new LT_THAMSODAO();
            return dao.Insert(tc);
        }
        public static bool Update(LT_THAMSO tc)
        {
            LT_THAMSODAO dao = new LT_THAMSODAO();
            return dao.Update(tc);
        }
        public static bool Delete(LT_THAMSO tc)
        {
            LT_THAMSODAO dao = new LT_THAMSODAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            LT_THAMSODAO dao = new LT_THAMSODAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_THAMSO tc)
        {
            LT_THAMSODAO dao = new LT_THAMSODAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            LT_THAMSODAO dao = new LT_THAMSODAO();
            return "TS" + dao.GetID().ToString();
        }
    }
}
