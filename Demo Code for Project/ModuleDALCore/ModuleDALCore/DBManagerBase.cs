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
        protected DataSet Dataset = null;
        protected DataTable Datatable = null;
        protected DbDataReader Datareader;
        protected bool Isopen;
        protected ProviderType ProviderType;

        protected DBManagerBase()
        {
            throw new System.NotImplementedException();
        }

        ~DBManagerBase()
        {
            throw new System.NotImplementedException();
        }

        public string ConnectionString
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Data.Common.DbConnection Connection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DbCommand Command
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ProviderType DBProvider
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DbDataReader DBReader
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool IsOpen
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DataSet DBset
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DataTable DBTable
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new System.NotImplementedException();
        }

        protected void Close()
        {
            throw new System.NotImplementedException();
        }

        protected void Open(string Connectionstring)
        {
            throw new System.NotImplementedException();
        }
    }
}
