using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    class OutReportFactory : IReportFactory
    {
        public AReport createReport(string type, string name)
        {
            AReport doc = null;

            switch (type)
            {
                case "INV":
                    doc = new OutInvoiceReport(name);
                    break;
                case "PUR":
                    doc = new OutPurchaseReport(name);
                    break;
                default:
                    break;
            }

            return doc;
        }
    }
}
