using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.DAO;
using QLKS.BLL.Object;
using System.Data;

namespace QLKS.BLL.BL
{
    public class NS_CHUCVUBUS
    {
        public NS_CHUCVUBUS() { }
        public static bool Insert(NS_CHUCVU tc)
        {
            NS_CHUCVUDAO dao = new NS_CHUCVUDAO();
            return dao.Insert(tc);
        }
        public static bool Update(NS_CHUCVU tc)
        {
            NS_CHUCVUDAO dao = new NS_CHUCVUDAO();
            return dao.Update(tc);
        }
        public static bool Delete(NS_CHUCVU tc)
        {
            NS_CHUCVUDAO dao = new NS_CHUCVUDAO();
            return dao.Delete(tc);
        }
        public static DataTable SelectAll()
        {
            NS_CHUCVUDAO dao = new NS_CHUCVUDAO();
            return dao.SelectALL();
        }
        public static DataTable SelectPK(NS_CHUCVU tc)
        {
            NS_CHUCVUDAO dao = new NS_CHUCVUDAO();
            return dao.SelectByPK(tc);
        }
        public static string GetID()
        {
            NS_CHUCVUDAO dao = new NS_CHUCVUDAO();
            return "CV" + dao.GetID().ToString();
        }
    }
}
