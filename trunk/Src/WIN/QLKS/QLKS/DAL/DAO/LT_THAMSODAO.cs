using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.BLL.Object;
using ModuleDALCore;
using QLKS.DAL.Core;
using System.Data;

namespace QLKS.DAL.DAO
{
    public class LT_THAMSODAO:DALBase
    {
        LT_THAMSO qg;
         private string _SpName;
        public string SpName
        {
            get { return "SpLT_THAMSO"; }
            set { _SpName = value; }
        }
        public LT_THAMSODAO()
        {
            OpenConnect();
        }
        public bool Insert(LT_THAMSO qg)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(qg, null), ConvertClassToArray.GetValues(qg,1)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Update(LT_THAMSO qg)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(qg, null), ConvertClassToArray.GetValues(qg,2)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(LT_THAMSO qg)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(qg, null), ConvertClassToArray.GetValues(qg,3)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public DataTable SelectByPK(LT_THAMSO qg)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(qg, null), ConvertClassToArray.GetValues(qg,4));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectALL()
        {
            qg = new LT_THAMSO();
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(qg, null), ConvertClassToArray.GetValues(qg,0));
            }
            catch
            {
                return null;
            }
        }
        public int GetID()
        {
            qg = new LT_THAMSO();
            try
            {
                return DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(qg, null), ConvertClassToArray.GetValues(qg, 5), DBConnectionState.CloseOnExit);
            }
            catch
            {
                return 0;
            }
        }
    }
}
