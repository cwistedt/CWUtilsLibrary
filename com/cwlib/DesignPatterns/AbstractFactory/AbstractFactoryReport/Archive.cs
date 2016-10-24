using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport
{
    class Archive
    {
        private List<AReport> reportList;

        public void addReport(string fam, string type, string name)
        {
            IReportFactory rf = FactoryProvider.getFactory(fam);
            if(this.reportList == null)
            {
                this.reportList = new List<AReport>();
            }
            this.reportList.Add(rf.createReport(type, name));
        }

        public void processAllReports()
        {
            foreach (AReport report in this.reportList)
            {
                report.processReport();
                Console.WriteLine("----");
            }
        }

    }
}
