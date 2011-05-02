using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace ModuleDALCore
{
    public abstract class DBManagerBase
    {
        protected string Connectionstring = String.Empty;
        protected DatabaseHelper DataHelpper = null;
        private DataSet _Dataset = null;
        protected DataSet Dataset
        {
            get { return _Dataset; }
            set { _Dataset = value; }
        }
        private DataTable _Datatable = null;
        protected DataTable Datatable
        {
            get { return _Datatable; }
            set { _Datatable = value; }
        }
        protected DbDataReader Datareader;
        protected bool Isopen;
        protected ProviderType ProviderType;
        protected DBManagerBase()
        {
        }
        ~DBManagerBase()
        {
        }
        public string ConnectionString
        {
            get
            {
                return this.Connectionstring;
            }
            set
            {
                Connectionstring = value;
            }
        }
        public DbConnection Connection
        {
            get
            {
                return this.DataHelpper.Connection;
            }
        }
        public DbCommand Command
        {
            get
            {
                return this.DataHelpper.Command;
            }
        }
        public ProviderType DBProvider
        {
            get
            {
                return this.ProviderType;
            }
            set
            {
                this.ProviderType = value;
            }
        }
        public DbDataReader DBReader
        {
            get
            {
                return this.Datareader;
            }
        }
        public bool IsOpen
        {
            get
            {
                return this.Isopen;
            }
            set
            {
                this.Isopen = value;
            }
        }
        public void BeginTransaction()
        {
            this.DataHelpper.BeginTransaction();
        }
        public void CommitTransaction()
        {
            this.DataHelpper.CommitTransaction();
        }
        public void RollbackTransaction()
        {
            this.DataHelpper.RollBackTransaction();
        }
        protected void Close()
        {
            if (this.Datareader != null && this.Datareader.IsClosed)
                this.Datareader.Close();
            this.Datareader.Dispose();
        }
        protected void Open(string Connectionstring)
        {
            this.DataHelpper = new DatabaseHelper(Connectionstring, this.ProviderType);
        }
    }
}
