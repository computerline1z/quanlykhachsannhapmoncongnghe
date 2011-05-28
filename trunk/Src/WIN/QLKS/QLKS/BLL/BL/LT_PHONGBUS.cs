using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using QLKS.BLL.Object;
using System.Data;

namespace QLKS.BLL.BL
{
    public class LT_PHONGBUS
    {
        public LT_PHONGBUS() { }
        public static bool Insert(LT_PHONG tc)
        {
            LT_PHONGDAO dao = new LT_PHONGDAO();
            return dao.Insert(tc);
        }
        public static bool Update(LT_PHONG tc)
        {
            LT_PHONGDAO dao = new LT_PHONGDAO();
            return dao.Update(tc);
        }
        public static bool Delete(LT_PHONG tc)
        {
            LT_PHONGDAO dao = new LT_PHONGDAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            LT_PHONGDAO dao = new LT_PHONGDAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(LT_PHONG tc)
        {
            LT_PHONGDAO dao = new LT_PHONGDAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            LT_PHONGDAO dao = new LT_PHONGDAO();
            return "PHG" + dao.GetID().ToString();
        }
    }
}
