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
        const int Extreme = -1;
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
            this.Command = this.Factory.CreateCommand();
            this.Connection.ConnectionString = connectionstring;
            this.Command.Connection = this.Connection;
            this.defaultProvider=provider;
        }
        internal int AddParameter(DbParameter parameter)
        {
            return this.Command.Parameters.Add(parameter);
        }
        internal int AddParameter(string name, object value)
        {
            DbParameter pa = this.Factory.CreateParameter();
            pa.ParameterName = name;
            pa.Value = value;
            return this.Command.Parameters.Add(pa);
        }
        internal int AddParameter(string name, object value, StoreProceduceParameterDirection sp)
        {
            DbParameter pa = this.Factory.CreateParameter();
            pa.ParameterName = name;
            pa.Value = value;
            pa.DbType = DbFactory.Type2DbType(value.GetType());
            switch (sp)
            {
                case StoreProceduceParameterDirection.Input:
                    pa.Direction = ParameterDirection.Input;
                    break;
                case StoreProceduceParameterDirection.InputOutput:
                    pa.Direction = ParameterDirection.InputOutput;
                    break;
                case StoreProceduceParameterDirection.Output:
                    pa.Direction = ParameterDirection.Output;
                    break;
                case StoreProceduceParameterDirection.ReturnValues:
                    pa.Direction = ParameterDirection.ReturnValue;
                    break;
            }
            return this.Command.Parameters.Add(pa);

        }
        internal void BeginTransaction()
        {
            if (this.Connection.State == ConnectionState.Closed)
            {
                this.Connection.Open();
            }
            this.Command.Transaction = this.Connection.BeginTransaction();
        }
        internal void CommitTransaction()
        {
            this.Command.Transaction.Commit();
            this.Connection.Close();
        }
        internal void RollBackTransaction()
        {
            this.Command.Transaction.Rollback();
            this.Connection.Close();
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
            DbDataAdapter da = this.Factory.CreateDataAdapter();
            this.Command.CommandText = query;
            this.Command.CommandType = ct;
            this.Command.CommandTimeout = 90;
            da.SelectCommand = this.Command;
            DataSet ds = new DataSet();
            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {

                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString()); ;
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (dc == DBConnectionState.CloseOnExit && this.Connection.State == ConnectionState.Open)
                {
                    this.Connection.Close();
                }
            }
            return ds;
        }
        internal DataSet ExecuteDataset(string query)
        {
            return this.ExecuteDataset(query, CommandType.Text, DBConnectionState.CloseOnExit);
        }
        internal DataSet ExecuteDataset(string query, DBConnectionState dc)
        {
            return this.ExecuteDataset(query, CommandType.Text, dc);
        }
        internal DataSet ExecuteDataset(string query, CommandType type)
        {
            return this.ExecuteDataset(query, type, DBConnectionState.CloseOnExit);
        }
        internal DataSet ExecuteDataset(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            DbDataAdapter da = this.Factory.CreateDataAdapter();
            this.Command.CommandText = spName;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 0x2328;
            DataSet ds = new DataSet();
            try
            {
                for (int i = 0; i < Params.Length; i++)
                {
                    this.AddParameter(this.FormatParameter(Params[i]), values[i]);
                }
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();
                da.SelectCommand = this.Command;
                da.Fill(ds);
            }
            catch(Exception ex)
            {
                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString());
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (state == DBConnectionState.CloseOnExit && this.Connection.State == ConnectionState.Open)
                {
                    this.Connection.Close();
                }
            }
            return ds;
        }
        internal DataTable ExecuteDataTable(string query, CommandType type, DBConnectionState dc)
        {
            DbDataAdapter da = this.Factory.CreateDataAdapter();
            this.Command.CommandText = query;
            this.Command.CommandType = type;
            da.SelectCommand = this.Command;
            DataTable dt = new DataTable();
            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString());
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (dc == DBConnectionState.CloseOnExit && this.Connection.State == ConnectionState.Open)
                    this.Connection.Close();
            }
            return dt;
        }
        internal DataTable ExecuteDataTable(string query)
        {
            return this.ExecuteDataTable(query, CommandType.Text, DBConnectionState.CloseOnExit);
        }
        internal DataTable ExecuteDataTable(string query, CommandType type)
        {
            return this.ExecuteDataTable(query, CommandType.Text);
        }
        internal DataTable ExecuteDataTable(string query, DBConnectionState dc)
        {
            return this.ExecuteDataTable(query, CommandType.Text);
        }
        internal DataTable ExecuteDataTable(string spName, string[] Params, object[] values, DBConnectionState state)
        {
            DbDataAdapter da = this.Factory.CreateDataAdapter();
            this.Command.CommandText = spName;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 90;
            DataTable dt = new DataTable();
            try
            {
                for (int i = 0; i < Params.Length; i++)
                {
                    this.AddParameter(this.FormatParameter(Params[i]), values[i]);
                }
                if (this.Connection.State == ConnectionState.Open)
                    this.Connection.Open();
                da.SelectCommand = this.Command;
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString());
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (state == DBConnectionState.CloseOnExit && this.Connection.State == ConnectionState.Open)
                    this.Connection.Close();
            }
            return dt;
        }
        internal int ExecuteNonQuery(string spName, string[] Params, object[] Values, DBConnectionState state, StoreProceduceParameterDirection sp)
        {
            this.Command.CommandText = spName;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 90;
            try
            {
                for (int i = 0; i < Params.Length; i++)
                {
                    this.AddParameter(this.FormatParameter(Params[i]), Values[i]);
                }
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();
                if (sp == StoreProceduceParameterDirection.ReturnValues)
                {
                    this.AddParameter(this.FormatParameter("RETURN_VALUE"), 0, sp);
                    this.Command.ExecuteNonQuery();
                    return Convert.ToInt32(this.Command.Parameters["RETURN_VALUE"].Value.ToString());
                }
            }
            catch (Exception ex)
            {

                throw new InvalidProgramException("Can't Excute Data beacause erorr is " + ex.ToString()); ;
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (state == DBConnectionState.CloseOnExit && this.Connection.State == ConnectionState.Open)
                    this.Connection.Close();
            }
            return Extreme;
        }
        private string FormatParameter(string Name)
        {
            switch (this.defaultProvider)
            { 
                case ProviderType.SqlServer:
                    return "@" + Name;
                case ProviderType.Oracle:
                    return Name;
            }
            return "?";
        }
        internal int ExecuteNonQuery(string query)
        {
            return this.ExecuteNonQuery(query, CommandType.Text,DBConnectionState.CloseOnExit);
        }
        internal int ExecuteNonQuery(string query, DBConnectionState connectionstate)
        {
            return this.ExecuteNonQuery(query,  CommandType.Text,connectionstate);
        }
        internal int ExecuteNonQuery(string query, CommandType commandtype)
        {
            return this.ExecuteNonQuery(query, commandtype,DBConnectionState.CloseOnExit);
        }
        internal int ExecuteNonQuery(string query, CommandType commandtype, DBConnectionState connectionstate)
        {
            this.Command.CommandText = query;
            this.Command.CommandType = commandtype;
            this.Command.CommandTimeout = 90;
            int i = Extreme;
            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();
                i = this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new InvalidProgramException("Can't Excute Data beacause erorr is " + ex.ToString());
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (connectionstate == DBConnectionState.CloseOnExit)
                    this.Connection.Close();
            }
            return i;

        }
        internal DbDataReader ExecuteReader(string query)
        {
            return this.ExecuteReader(query, CommandType.Text, DBConnectionState.CloseOnExit);
        }
        internal DbDataReader ExecuteReader(string query, DBConnectionState connectionstate)
        {
            return this.ExecuteReader(query, CommandType.Text, connectionstate);
        }
        internal DbDataReader ExecuteReader(string query, CommandType commandtype)
        {
            return this.ExecuteReader(query, commandtype, DBConnectionState.CloseOnExit);
        }
        internal DbDataReader ExecuteReader(string spName, params object[] parameters)
        {
            //ham su dung store with excute reader
            return null;
        }
        internal DbDataReader ExecuteReader(string query, CommandType commandtype, DBConnectionState connectionstate)
        {
            this.Command.CommandText = query;
            this.Command.CommandType = commandtype;
            this.Command.CommandTimeout = 90;
            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();
                if (connectionstate == DBConnectionState.CloseOnExit)
                    return this.Command.ExecuteReader(CommandBehavior.CloseConnection);
                return this.Command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString()); 
            }
            finally
            {
                this.Command.Parameters.Clear();
            }
            return null;
        }
        internal DbDataReader ExecuteReader(string spName, string[] Params, object[] Values, DBConnectionState connecttionsate)
        {
            object[] CS = new object[4];
            CS[0] = Params;
            CS[1] = Values;
            CS[2] = connecttionsate;
            return (DbDataReader)this.ExecuteReader(spName, CS);
        }
        internal DbDataReader ExecuteReader(string spName, string[] Params, object[] Values, DBConnectionState connecttionsate, StoreProceduceParameterDirection parameterDirection)
        {
            this.Command.CommandText = spName;
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                for (int i = 0; i < Params.Length; i++)
                {
                    this.AddParameter(this.FormatParameter(Params[i]), Values[i], parameterDirection);
                }
                if (this.Connection.State == ConnectionState.Closed)
                {
                    this.Connection.Open();
                }
                if (connecttionsate == DBConnectionState.CloseOnExit)
                {
                    return this.Command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                return this.Command.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString()); ;
            }
            finally
            {
                this.Command.Parameters.Clear();
            }
            return null;
        }
        internal object ExecuteScalar(string query)
        {
            return this.ExecuteScalar(query, CommandType.Text, DBConnectionState.CloseOnExit);
        }
        internal object ExecuteScalar(string query, DBConnectionState connectionstate)
        {
            return this.ExecuteScalar(query, CommandType.Text, connectionstate);
        }
        internal object ExecuteScalar(string query, CommandType commandtype, DBConnectionState connectionstate)
        {
            this.Command.CommandText = query;
            this.Command.CommandType = commandtype;
            object o = null;
            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                {
                    this.Connection.Open();
                }
                o = this.Command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString()); ;
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (connectionstate == DBConnectionState.CloseOnExit)
                {
                    this.Connection.Close();
                }
            }
            return o;
        }
        internal object ExecuteScalar(string spName, string[] Params, object[] Values, DBConnectionState connectionstate)
        {
            this.Command.CommandText = spName;
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 0x2328;
            object o = null;
            try
            {
                for (int i = 0; i < Params.Length; i++)
                {
                    this.AddParameter(this.FormatParameter(Params[i]), Values[i]);
                }
                if (this.Connection.State == ConnectionState.Closed)
                {
                    this.Connection.Open();
                }
                o = this.Command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new InvalidProgramException("Can't Fill Data  because erorr is " + ex.Message.ToString()); ; 
            }
            finally
            {
                this.Command.Parameters.Clear();
                if (connectionstate == DBConnectionState.CloseOnExit)
                {
                    this.Connection.Close();
                }
            }
            return o;
        }
    }
}
