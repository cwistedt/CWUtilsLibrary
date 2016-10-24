using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    abstract class AInReport : AReport
    {

        protected AInReport(string name) : base(name)
        {
            
        }

        public override void processReport()
        {
            base.processReport();
            System.Console.WriteLine("Performing IN Reports common stuff");
        }


    }
}
