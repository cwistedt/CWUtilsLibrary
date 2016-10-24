using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    abstract class AOutReport : AReport
    {
        protected AOutReport(string name) : base(name)
        {

        }

        public override void processReport()
        {
            base.processReport();
            Console.WriteLine("Performing OUT Reports common stuff");
        }
    }
}
