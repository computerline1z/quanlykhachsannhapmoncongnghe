using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLKS.BLL.Object;
using ModuleDALCore;
using QLKS.DAL.Core;

namespace QLKS.DAL.DAO
{
    public class NS_NHANVIENDAO:DALBase
    {
         NS_NHANVIEN lp;
         private string _SpName;
        public string SpName
        {
            get { return "SpNS_NhanVien"; }
            set { _SpName = value; }
        }
        public NS_NHANVIENDAO()
        {
            OpenConnect();
        }
        public bool Insert(NS_NHANVIEN lp)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lp, null), ConvertClassToArray.GetValues(lp,1)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Update(NS_NHANVIEN lp)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lp, null), ConvertClassToArray.GetValues(lp,2)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(NS_NHANVIEN lp)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lp, null), ConvertClassToArray.GetValues(lp,3)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public DataTable SelectByPK(NS_NHANVIEN lp)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(lp, null), ConvertClassToArray.GetValues(lp,4));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectALL()
        {
            lp = new NS_NHANVIEN();
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(lp, null), ConvertClassToArray.GetValues(lp,0));
            }
            catch
            {
                return null;
            }
        }
        public int GetID()
        {
            lp = new NS_NHANVIEN();
            try
            {
                return DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lp, null), ConvertClassToArray.GetValues(lp, 5), DBConnectionState.CloseOnExit);
            }
            catch
            {
                return 0;
            }
        }
    }
}
