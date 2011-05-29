using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAL.Core;
using QLKS.BLL.Object;
using ModuleDALCore;
using System.Data;
namespace QLKS.DAL.DAO
{
    public class LT_QUANDAO:DALBase
    {
        LT_QUAN quan;
         private string _SpName;
        public string SpName
        {
            get { return "SpLT_QUAN"; }
            set { _SpName = value; }
        }
        public LT_QUANDAO()
        {
            OpenConnect();
        }
        public bool Insert(LT_QUAN quan)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan,1)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Update(LT_QUAN quan)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan,2)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(LT_QUAN quan)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan,3)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public DataTable SelectByPK(LT_QUAN quan)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan,4));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectByTP(LT_QUAN quan)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan, 6));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectALL()
        {
            quan = new LT_QUAN();
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan,0));
            }
            catch
            {
                return null;
            }
        }
        public int GetID()
        {
            quan = new LT_QUAN();
            try
            {
                return DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(quan, null), ConvertClassToArray.GetValues(quan, 5), DBConnectionState.CloseOnExit);
            }
            catch
            {
                return 0;
            }
        }
    }
}
