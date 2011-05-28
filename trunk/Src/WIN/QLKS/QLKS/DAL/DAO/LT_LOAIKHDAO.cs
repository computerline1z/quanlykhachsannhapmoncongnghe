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
    public class LT_LOAIKHDAO:DALBase
    {
        LT_LOAIKH lkh;
         private string _SpName;
        public string SpName
        {
            get { return "SpLT_LOAIKH"; }
            set { _SpName = value; }
        }
        public LT_LOAIKHDAO()
        {
            OpenConnect();
        }
        public bool Insert(LT_LOAIKH lkh)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lkh, null), ConvertClassToArray.GetValues(lkh,1)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Update(LT_LOAIKH lkh)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lkh, null), ConvertClassToArray.GetValues(lkh,2)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(LT_LOAIKH lkh)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lkh, null), ConvertClassToArray.GetValues(lkh,3)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public DataTable SelectByPK(LT_LOAIKH lkh)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(lkh, null), ConvertClassToArray.GetValues(lkh,4));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectALL()
        {
            lkh = new LT_LOAIKH();
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(lkh, null), ConvertClassToArray.GetValues(lkh,0));
            }
            catch
            {
                return null;
            }
        }
        public int GetID()
        {
            lkh = new LT_LOAIKH();
            try
            {
                return DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(lkh, null), ConvertClassToArray.GetValues(lkh, 5), DBConnectionState.CloseOnExit);
            }
            catch
            {
                return 0;
            }
        }
    }
}
