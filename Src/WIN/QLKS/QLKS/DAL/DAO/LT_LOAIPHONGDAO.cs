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
    public class LT_LOAIPHONGDAO:DALBase
    {
         LT_LOAIPHONG lp;
         private string _SpName;
        public string SpName
        {
            get { return "SpLT_LOAIPHONG"; }
            set { _SpName = value; }
        }
        public LT_LOAIPHONGDAO()
        {
            OpenConnect();
        }
        public bool Insert(LT_LOAIPHONG lp)
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
        public bool Update(LT_LOAIPHONG lp)
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
        public bool Delete(LT_LOAIPHONG lp)
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
        public DataTable SelectByPK(LT_LOAIPHONG lp)
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
            lp = new LT_LOAIPHONG();
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
            lp = new LT_LOAIPHONG();
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
