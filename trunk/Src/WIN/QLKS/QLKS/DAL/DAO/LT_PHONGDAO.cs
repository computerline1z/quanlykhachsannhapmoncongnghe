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
    public class LT_PHONGDAO:DALBase
    {
        LT_PHONG qg;
         private string _SpName;
        public string SpName
        {
            get { return "SpLT_PHONG"; }
            set { _SpName = value; }
        }
        public LT_PHONGDAO()
        {
            OpenConnect();
        }
        public bool Insert(LT_PHONG qg)
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
        public bool Update(LT_PHONG qg)
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
        public bool Delete(LT_PHONG qg)
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
        public DataTable SelectByPK(LT_PHONG qg)
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
            qg = new LT_PHONG();
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
            qg = new LT_PHONG();
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
