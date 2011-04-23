using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace ModuleDALCore
{
    public class DatabaseHelper : IDisposable
    {
        private readonly ProviderType defaultProvider;
        private DbCommand objCommand;
        internal DbCommand Command
        {
            get { return objCommand; }
            set { objCommand = value; }
        }
        private DbConnection objConnection;
        internal DbConnection Connection
        {
            get { return objConnection; }
            set { objConnection = value; }
        }
        private DbProviderFactory objFactory;
        private string strConnectionString;
        public DatabaseHelper()
        {
            throw new System.NotImplementedException();
        }
        public DatabaseHelper(string connectionstring, ProviderType provider)
        {
            throw new System.NotImplementedException();
        }
        internal int AddParameter(DbParameter parameter)
        {
            throw new System.NotImplementedException();
        }
        internal int AddParameter(string name, object value)
        {
            throw new System.NotImplementedException();
        }
        internal int AddParameter(string name, object value, StoreProceduceParameterDirection sp)
        {
            throw new System.NotImplementedException();
        }
        internal void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }
        internal void CommitTransaction()
        {
            throw new System.NotImplementedException();
        }
        internal void RollBackTransaction()
        {
            throw new System.NotImplementedException();
        }
        internal void Dispose()
        {
            throw new System.NotImplementedException();
        }
        internal DataSet ExecuteDataset(string query, CommandType ct, DBConnectionState dc)
        {
            throw new System.NotImplementedException();
        }
        internal DataSet ExecuteDataset(string query)
        {
            throw new System.NotImplementedException();
        }
        internal DataSet ExecuteDataset(string query, DBConnectionState dc)
        {
            throw new System.NotImplementedException();
        }
        internal DataSet ExecuteDataset(string query, CommandType type)
        {
            throw new System.NotImplementedException();
        }
        internal DataSet ExecuteDataset(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        internal DataTable ExecuteDataTable(string query, CommandType type, DBConnectionState dc)
        {
            throw new System.NotImplementedException();
        }
        internal DataTable ExecuteDataTable(string query)
        {
            throw new System.NotImplementedException();
        }
        internal DataTable ExecuteDataTable(string query, CommandType type)
        {
            throw new System.NotImplementedException();
        }
        internal DataTable ExecuteDataTable(string query, DBConnectionState dc)
        {
            throw new System.NotImplementedException();
        }
        internal DataTable ExecuteDataTable(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            throw new System.NotImplementedException();
        }
        internal int ExecuteNonQuery(string spName, string[] Params, object[] Values, DBConnectionState state, StoreProceduceParameterDirection sp)
        {
            throw new System.NotImplementedException();
        }
        private string FormatParameter(string Name)
        {
            throw new System.NotImplementedException();
        }
        internal int ExecuteNonQuery(string query)
        {
            throw new System.NotImplementedException();
        }
        internal int ExecuteNonQuery(string query, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
        internal int ExecuteNonQuery(string query, CommandType commandtype)
        {
            throw new System.NotImplementedException();
        }
        internal int ExecuteNonQuery(string query, CommandType commandtype, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string query)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string query, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string query, CommandType commandtype)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string spName, params object[] parameters)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string query, CommandType commandtype, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string spName, string[] Params, object[] Values, DBConnectionState connecttionsate)
        {
            throw new System.NotImplementedException();
        }
        internal DbDataReader ExecuteReader(string spName, string[] Params, object[] Values, DBConnectionState connecttionsate, StoreProceduceParameterDirection parameterDirection)
        {
            throw new System.NotImplementedException();
        }
        internal object ExecuteScalar(string query)
        {
            throw new System.NotImplementedException();
        }
        internal object ExecuteScalar(string query, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
        internal object ExecuteScalar(string query, CommandType commandtype, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
        internal object ExecuteScalar(string spName, string[] Params, object[] Values, DBConnectionState connectionstate)
        {
            throw new System.NotImplementedException();
        }
    }
}
