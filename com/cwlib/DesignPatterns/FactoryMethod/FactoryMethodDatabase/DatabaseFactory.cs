using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodDatabase
{
    class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType DatabaseType)
        {
            switch (DatabaseType)
            {
                case DatabaseType.OleDb:
                    return new OleDBDatabase();
                case DatabaseType.SqlServer:
                default:
                    return new SqlServerDatabase();
            }
        }
    }
}
