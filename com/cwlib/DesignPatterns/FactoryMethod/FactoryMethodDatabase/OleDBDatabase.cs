﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using System.Data.OleDb;
using System.Data;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodDatabase
{
    class OleDBDatabase: IDatabase
    {
        private IDbConnection _Connection = null;
        private IDbCommand _Command = null;

        public IDbConnection Connection
        {
            get
            {
                if(_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OleDBConnection"].ConnectionString;
                    _Connection = new OleDbConnection(connectionString);
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
                    _Command = new OleDbCommand();
                    _Command.Connection = (OleDbConnection)Connection;
                }
                return _Command;
            }
        }


    }
}
