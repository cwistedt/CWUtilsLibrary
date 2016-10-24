using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    abstract class AReport
    {
        protected string name;

        protected AReport(string name)
        {
            this.name = name;
        }

        public virtual void processReport()
        {
            Console.WriteLine("Processing report: " + this.name);
        }
    }
}
