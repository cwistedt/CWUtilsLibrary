using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    class InInvoiceReport : AInReport
    {
        public InInvoiceReport(string name) : base(name)
        {

        }

        public override void processReport()
        {
            base.processReport();
            Console.WriteLine("Performing IN Reports Invoice specific stuff");
        }
    }
}
