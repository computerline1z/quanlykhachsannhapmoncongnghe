using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLKS.BLL.Object;
using QLKS.DAL.Core;
using ModuleDALCore;

namespace QLKS.DAL.DAO
{
    public class NS_CHUCVUDAO:DALBase
    {
        NS_CHUCVU cv;
         private string _SpName;
        public string SpName
        {
            get { return "SpNS_CHUCVU"; }
            set { _SpName = value; }
        }
        public NS_CHUCVUDAO()
        {
            OpenConnect();
        }
        public bool Insert(NS_CHUCVU cv)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(cv, null), ConvertClassToArray.GetValues(cv,1)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Update(NS_CHUCVU cv)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(cv, null), ConvertClassToArray.GetValues(cv,2)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(NS_CHUCVU cv)
        {
            try
            {
                return (DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(cv, null), ConvertClassToArray.GetValues(cv,3)) == 1);
            }
            catch
            {
                return false;
            }
        }
        public DataTable SelectByPK(NS_CHUCVU cv)
        {
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(cv, null), ConvertClassToArray.GetValues(cv,4));
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectALL()
        {
            cv = new NS_CHUCVU();
            try
            {
                return DBManager.Intance.ExecuteDataTable(SpName, ConvertClassToArray.GetParamName(cv, null), ConvertClassToArray.GetValues(cv,0));
            }
            catch
            {
                return null;
            }
        }
        public int GetID()
        {
            cv = new NS_CHUCVU();
            try
            {
                return DBManager.Intance.ExecuteNonQuery(SpName, ConvertClassToArray.GetParamName(cv, null), ConvertClassToArray.GetValues(cv, 5), DBConnectionState.CloseOnExit);
            }
            catch
            {
                return 0;
            }
        }
    }
}
