using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace ModuleDALCore
{
    public sealed class DBManager:DBManagerBase
    {
        private static DBManager _intance;

        static DBManager()
        {
            throw new System.NotImplementedException();
        }

        private DBManager(ProviderType type, string Connectionstring)
        {
            base.Connectionstring = Connectionstring;
            base.DBProvider = type;
        }
    
        public static DBManager Intance
        {
            get
            {
                if (_intance == null)
                    throw new InvalidProgramException("Much call Initialize() first to setup DbConnection");
                return _intance;
            }
        }

        public int AddParameter(DbParameter pa)
        {
            throw new System.NotImplementedException();
        }
        public int AddParameter(string name, object value)
        {
            throw new System.NotImplementedException();
        }
        public int AddParameter(string name, object value, StoreProceduceParameterDirection sp)
        {
            throw new System.NotImplementedException();
        }

        private void CloseConnection()
        {
            throw new System.NotImplementedException();
        }

        public void OpenConnection(string Connectionstring)
        {
            throw new System.NotImplementedException();
        }

        public static void Release()
        {
            throw new System.NotImplementedException();
        }

        public DataSet ExecuteDataSet(string query)
        {
            throw new System.NotImplementedException();
        }
        public DataSet ExecuteDataSet(string query, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        public DataSet ExecuteDataSet(string spName, string[] Params, object[] value)
        {
            throw new System.NotImplementedException();
        }
        public DataSet ExecuteDataSet(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        public DataTable ExecuteDataTable(string query)
        {
            throw new System.NotImplementedException();
        }
        public DataTable ExecuteDataTable(string query, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        public DataTable ExecuteDataTable(string spName, string[] Params, object[] values)
        {
            throw new System.NotImplementedException();
        }
        public DataTable ExecuteDataTable(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }

        public int ExecuteNonQuery(string query)
        {
            throw new System.NotImplementedException();
        }
        public int ExecuteNonQuery(string query, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        public int ExecuteNonQuery(string spName, string[] Params, object[] values)
        {
            throw new System.NotImplementedException();
        }
        public int ExecuteNonQuery(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }

        public DbDataReader ExecuteReader(string query)
        {
            throw new System.NotImplementedException();
        }
        public DbDataReader ExecuteReader(string query, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        public DbDataReader ExecuteReader(string spName, string[] Params, object[] values)
        {
            throw new System.NotImplementedException();
        }
        public DbDataReader ExecuteReader(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }

        public object ExecuteScalar(string query)
        {
            throw new System.NotImplementedException();
        }
        public object ExecuteScalar(string query, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        public object ExecuteScalar(string spName, string[] Params, object[] values)
        {
            throw new System.NotImplementedException();
        }
        public object ExecuteScalar(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// ham khoi tao class luon luon goi ham nay truoc khi chay
        /// </summary>
        /// <param name="type">kieu cua loai co so du lieu</param>
        /// <param name="connectionstring">chuoi ket noi</param>
        public static void Initialize(ProviderType type, string connectionstring)
        {
            if (type == ProviderType.Default)
                type = ProviderType.SqlServer;
            _intance = new DBManager(type, connectionstring);
            _intance.OpenConnection(connectionstring);
        }
    }
}
