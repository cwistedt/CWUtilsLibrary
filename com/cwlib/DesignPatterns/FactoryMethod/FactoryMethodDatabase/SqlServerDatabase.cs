using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodDatabase
{
    class SqlServerDatabase: IDatabase
    {
        private SqlConnection _Connection = null;
        private SqlCommand _Command = null;

        public IDbConnection Connection
        {
            get
            {
                if(_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
                    _Connection = new SqlConnection(connectionString);
                }
                return _Connection;
            }
        }

        public IDbCommand Command
        {
            get
            {
                if(_Command == null)
                {
                    _Command.Connection = (SqlConnection)Connection;
                    _Command = new SqlCommand();
                }
                return _Command;
            }
        }
    }
}
