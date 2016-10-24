using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    abstract class FactoryProvider
    {

        public static IReportFactory getFactory(string factoryType)
        {
            IReportFactory rf = null;
            switch(factoryType)
            {
                case "IN":
                    rf = new InReportFactory();
                    break;
                case "OUT":
                    rf = new OutReportFactory();
                    break;
                default:
                    break;
            }
            return rf;
            
        }  
    }
}
