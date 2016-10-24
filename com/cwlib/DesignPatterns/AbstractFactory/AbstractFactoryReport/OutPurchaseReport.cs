using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    class OutPurchaseReport : AOutReport
    {
        public OutPurchaseReport(string name) : base(name)
        {

        }

        public override void processReport()
        {
            base.processReport();
            Console.WriteLine("Performing OUT Reports Purchase specific stuff");
        }
    }
}
