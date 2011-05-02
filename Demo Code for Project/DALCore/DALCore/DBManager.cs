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
            return this.DataHelpper.AddParameter(pa);
        }
        public int AddParameter(string name, object value)
        {
            return this.DataHelpper.AddParameter(name, value);
        }
        public int AddParameter(string name, object value, StoreProceduceParameterDirection sp)
        {
            return this.DataHelpper.AddParameter(name, value, sp);
        }

        private void CloseConnection()
        {
            if (base.IsOpen)
                base.Close();
            base.IsOpen = false;
        }

        public void OpenConnection(string Connectionstring)
        {
            if (!base.IsOpen)
                base.Open(Connectionstring);
            base.IsOpen = true;
        }

        public static void Release()
        {
            if (_intance != null)
            {
                _intance.CloseConnection();
                _intance = null;
            }
        }

        public DataSet ExecuteDataSet(string query)
        {
            base.Dataset = base.DataHelpper.ExecuteDataset(query);
            return base.Dataset;
        }
        public DataSet ExecuteDataSet(string query, DBConnectionState state)
        {
            base.Dataset = base.DataHelpper.ExecuteDataset(query, state);
            return base.Dataset;
        }
        public DataSet ExecuteDataSet(string spName, string[] Params, object[] value)
        {
            base.Dataset = base.DataHelpper.ExecuteDataset(spName, Params, value, DBConnectionState.CloseOnExit);
            return base.Dataset;
        }
        public DataSet ExecuteDataSet(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            base.Dataset = base.DataHelpper.ExecuteDataset(spName, Params, values, state);
            return base.Dataset;
        }
        public DataTable ExecuteDataTable(string query)
        {
            base.Datatable = base.DataHelpper.ExecuteDataTable(query);
            return base.Datatable;
        }
        public DataTable ExecuteDataTable(string query, DBConnectionState state)
        {
            base.Datatable = base.DataHelpper.ExecuteDataTable(query, state);
            return base.Datatable;
        }
        public DataTable ExecuteDataTable(string spName, string[] Params, object[] values)
        {
            base.Datatable = base.DataHelpper.ExecuteDataTable(spName, Params, values, DBConnectionState.CloseOnExit);
            return base.Datatable;
        }
        public DataTable ExecuteDataTable(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            base.Datatable = base.DataHelpper.ExecuteDataTable(spName, Params, values, state);
            return base.Datatable;
        }
        public int ExecuteNonQuery(string query)
        {
            return base.DataHelpper.ExecuteNonQuery(query);
        }
        public int ExecuteNonQuery(string query, DBConnectionState state)
        {
            return base.DataHelpper.ExecuteNonQuery(query, state);
        }
        public int ExecuteNonQuery(string spName, string[] Params, object[] values)
        {
            return base.DataHelpper.ExecuteNonQuery(spName, Params, values, DBConnectionState.CloseOnExit, StoreProceduceParameterDirection.ReturnValues);
        }
        public int ExecuteNonQuery(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            return base.DataHelpper.ExecuteNonQuery(spName, Params, values, state, StoreProceduceParameterDirection.ReturnValues);
        }
        public int ExecuteNonQueryWithTransaction(string query, CommandType type, DBConnectionState connectionstate)
        {
            return base.DataHelpper.ExecuteNonQueryWithTransaction(query, type, connectionstate);
        }
        public DbDataReader ExecuteReader(string query)
        {
            base.Datareader=base.DataHelpper.ExecuteReader(query);
            return base.Datareader;
        }
        public DbDataReader ExecuteReader(string query, DBConnectionState state)
        {
            base.Datareader= base.DataHelpper.ExecuteReader(query, state);
            return base.Datareader;
        }
        public DbDataReader ExecuteReader(string spName, string[] Params, object[] values)
        {
            base.Datareader= base.DataHelpper.ExecuteReader(spName, Params, values, DBConnectionState.CloseOnExit);
            return base.Datareader;
        }
        public DbDataReader ExecuteReader(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            base.Datareader = base.DataHelpper.ExecuteReader(spName, Params, values, state);
            return base.Datareader;
        }
        public object ExecuteScalar(string query)
        {
            return base.DataHelpper.ExecuteScalar(query);
        }
        public object ExecuteScalar(string query, DBConnectionState state)
        {
            return base.DataHelpper.ExecuteScalar(query, state);
        }
        public object ExecuteScalar(string spName, string[] Params, object[] values)
        {
            return base.DataHelpper.ExecuteScalar(spName, Params, values, DBConnectionState.CloseOnExit);
        }
        public object ExecuteScalar(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            return base.DataHelpper.ExecuteScalar(spName, Params, values, state);
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
