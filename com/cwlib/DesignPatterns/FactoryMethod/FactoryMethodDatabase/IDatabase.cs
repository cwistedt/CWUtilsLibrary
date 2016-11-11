using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodDatabase
{
    interface IDatabase
    {
        IDbConnection Connection { get; }
        IDbCommand Command { get; }
    }
}
