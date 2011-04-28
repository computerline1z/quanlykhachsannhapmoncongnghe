using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.OracleClient;
namespace ModuleDALCore
{
    public class DatabaseHelper : IDisposable
    {
        private readonly ProviderType defaultProvider;

        public ProviderType DefaultProvider
        {
            get { return defaultProvider; }
        } 
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

        public DbProviderFactory Factory
        {
            get { return objFactory; }
            set { objFactory = value; }
        }
        private string strConnectionString;

        public string StrConnectionString
        {
            get { return strConnectionString; }
            set { strConnectionString = value; }
        }
        public DatabaseHelper()
        {
        }
        public DatabaseHelper(string connectionstring, ProviderType provider)
        {
            this.StrConnectionString = connectionstring;
            this.Factory = DbFactory.GetProvider(provider);
            this.Connection = this.Factory.CreateConnection();
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
        public void Dispose()
        {
            if (this.objConnection.State == System.Data.ConnectionState.Open)
            {
                this.objConnection.Close();
                this.objConnection.Dispose();
            }
            this.objCommand.Dispose();
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
