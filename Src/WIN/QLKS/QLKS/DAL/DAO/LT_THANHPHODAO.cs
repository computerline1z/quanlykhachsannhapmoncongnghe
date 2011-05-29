using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ModuleDALCore;
using QLKS.DAL.Core;
using QLKS.BLL.Object;

namespace QLKS.DAL.DAO
{
    public class LT_THANHPHODAO:DALBase
    {
         LT_THANHPHO tp;
         private string _SpName;
        public string SpName
        {
            get { return "SpLT_THANHPHO"; }
            set { _SpName = value; }
        }
        public LT_THANHPHODAO()
        {
            OpenConnect();
        }
        public bool Insert(LT_THANHPHO tp)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp,1)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Update(LT_THANHPHO tp)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp,2)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(LT_THANHPHO tp)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp,3)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public DataTable SelectByPK(LT_THANHPHO tp)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp,4));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectALL()
        {
            tp = new LT_THANHPHO();
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp,0));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectByQG(LT_THANHPHO tp)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp, 6));
            }
            catch
            {
                return null;
            }
        }
        public int GetID()
        {
            tp = new LT_THANHPHO();
            try
            {
                return DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(tp, null), ConvertClassToArray.GetValues(tp, 5), DBConnectionState.CloseOnExit);
            }
            catch
            {
                return 0;
            }
        }
    }
}
