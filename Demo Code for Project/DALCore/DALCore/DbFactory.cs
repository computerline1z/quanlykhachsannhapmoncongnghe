using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace ModuleDALCore
{
    internal class DbFactory
    {
        private static DbProviderFactory objFactory = null;

        public DbFactory()
        {
            
        }
        ~DbFactory()
        {
        }
        public static DbProviderFactory Factory
        {
            get
            {
                return objFactory;
            }
            set
            {
                objFactory = value;
            }
        }
        public static DbDataAdapter GetDataAdapter(ProviderType type)
        {
            switch (type)
            { 
                case ProviderType.SqlServer:
                    return new SqlDataAdapter();
                case ProviderType.Oracle:
                    return new OracleDataAdapter();
                case ProviderType.OleDb:
                    return new OleDbDataAdapter();
                case ProviderType.ODBC:
                    return new OdbcDataAdapter();
                case ProviderType.Default:
                    return new SqlDataAdapter();
            }
            return null;
        }
        public static DbProviderFactory GetProvider(ProviderType type)
        {
            switch (type)
            { 
                case ProviderType.SqlServer:
                    objFactory = SqlClientFactory.Instance;
                    break;
                case ProviderType.Oracle:
                    objFactory = OracleClientFactory.Instance;
                    break;
                case ProviderType.OleDb:
                    objFactory = OleDbFactory.Instance;
                    break;
                case ProviderType.ODBC:
                    objFactory = OdbcFactory.Instance;
                    break;
                case ProviderType.Default:
                    objFactory = SqlClientFactory.Instance;
                    break;
            }
            return objFactory;
        }
        public static DbType Type2DbType(Type type)
        {
            if (type == typeof(byte))
                return DbType.Byte;
            if (type == typeof(bool))
                return DbType.Boolean;
            if (type == typeof(string))
                return DbType.String;
            if (type == typeof(short))
                return DbType.Int16;
            if (type == typeof(int))
                return DbType.Int32;
            if (type == typeof(long))
                return DbType.Int64;
            if (type == typeof(ushort))
                return DbType.UInt16;
            if (type == typeof(uint))
                return DbType.UInt32;
            if (type == typeof(ulong))
                return DbType.UInt64;
            if (type == typeof(decimal) || type == typeof(double) || type == typeof(float))
                return DbType.Decimal;
            if (type == typeof(DateTime))
                return DbType.DateTime;
            return DbType.Object;
        }
    }
}
