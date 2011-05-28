using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using QLKS.BLL.Object;
using System.Data;

namespace QLKS.BLL.BL
{
    public class NS_NHANVIENBUS
    {
        public NS_NHANVIENBUS() { }
        public static bool Insert(NS_NHANVIEN tc)
        {
            NS_NHANVIENDAO dao = new NS_NHANVIENDAO();
            return dao.Insert(tc);
        }
        public static bool Update(NS_NHANVIEN tc)
        {
            NS_NHANVIENDAO dao = new NS_NHANVIENDAO();
            return dao.Update(tc);
        }
        public static bool Delete(NS_NHANVIEN tc)
        {
            NS_NHANVIENDAO dao = new NS_NHANVIENDAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            NS_NHANVIENDAO dao = new NS_NHANVIENDAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(NS_NHANVIEN tc)
        {
            NS_NHANVIENDAO dao = new NS_NHANVIENDAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            NS_NHANVIENDAO dao = new NS_NHANVIENDAO();
            return "NV" + dao.GetID().ToString();
        }
    }
}
