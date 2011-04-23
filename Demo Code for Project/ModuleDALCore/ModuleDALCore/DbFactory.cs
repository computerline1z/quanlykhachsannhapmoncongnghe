using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace ModuleDALCore
{
    internal class DbFactory
    {
        private static DbProviderFactory objFactory = null;

        public DbFactory()
        {
            throw new System.NotImplementedException();
        }

        ~DbFactory()
        {
            throw new System.NotImplementedException();
        }

        public static DbProviderFactory ObjFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static DbDataAdapter GetDataAdapter(ProviderType type)
        {
            throw new System.NotImplementedException();
        }

        public static DbProviderFactory GetProvider(ProviderType type)
        {
            throw new System.NotImplementedException();
        }

        public static DbType Type2DbType(Type type)
        {
            throw new System.NotImplementedException();
        }
    }
}
