using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;

using com.cwlib.DesignPatterns.Flyweight.FlyweightMoney;
using com.cwlib.DesignPatterns.Flyweight.FlyweightUserCache;
using com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryDatabase;
using com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport;

namespace com.cwlib.DesignPatterns.Test
{
    public class TestRun
    {
        private static TestRun Instance { get; set; }

        public static void Run(string designPattern)
        {
            if (TestRun.Instance == null)
                TestRun.Instance = new TestRun();

            switch (designPattern)
            {
                case "FlyweightMoney":
                    Instance.FlyweightMoney();
                    break;
                case "FlyweightUserCache":
                    Instance.FlyweightUserCache();
                    break;
                case "AbstractFactoryDatabase":
                    Instance.AbstractFactoryDatabase("SQL");
                    Instance.AbstractFactoryDatabase("OLEDB");
                    break;
                case "AbstractFactoryReports":
                    Instance.AbstractFactoryReport();
                    break;
                default:
                    Console.WriteLine("Design Pattern " + designPattern + " does not exists");
                    break;
            }

        }

        private void FlyweightUserCache()
        {
            FlyweightUserFactory fwuf = new FlyweightUserFactory();

            Guid guid_1 = Guid.NewGuid();
            fwuf.GetUser(guid_1); //Getting user 1, also saving in cache
            fwuf.GetUser(guid_1); //Getting user 1, from cache;            
        }

        private void FlyweightMoney()
        {
            const int ONE_MILLION = 10000;
            int[] currencyDenominations = new[] { 1, 5, 10, 20, 50, 100 };
            MoneyFactory moneyFactory = new MoneyFactory();
            int sum = 0;

            while (sum <= ONE_MILLION)
            {
                IMoney graphicalMoneyObj = null;
                Random rand = new Random();
                int currencyDisplayValue = currencyDenominations[rand.Next(0, currencyDenominations.Length)];
                if (currencyDisplayValue == 1 || currencyDisplayValue == 5)
                {
                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(EnMoneyType.Metallic);
                }
                else
                {
                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(EnMoneyType.Paper);
                }

                graphicalMoneyObj.GetDisplayOfMoneyFalling(currencyDisplayValue);
                sum = sum + currencyDisplayValue;
            }

            Console.WriteLine("Total Objects Created=" + MoneyFactory.ObjectsCount);
        }

        private void AbstractFactoryDatabase(string type)
        {
            Database database;
            if (type == "SQL")
            {
                Console.WriteLine("Creating SqlServerDatabase");
                database = new SqlServerDatabase();
            }
            else
            {
                Console.WriteLine("Creating OleDBDatabase");
                database = new OleDBDatabase();
            }

            //The Abstract Factory
            DbCommand command = database.Command;

            //Do some database stuff...
        }

        private void AbstractFactoryReport()
        {
            string[] reports = { "IN_INV_001.txt", "OUT_PUR_001.txt", "IN_INV_002.txt", "IN_PUR_001.txt", "OUT_PUR_002.txt", "OUT_INV_001.txt", "IN_INV_003.txt" };
            string[] tmp = null;

            Archive archive = new Archive();

            foreach (string s in reports)
            {
                char[] a = { '_' };
                tmp = s.Split(a);
                archive.addReport(tmp[0], tmp[1], s);
            }

            archive.processAllReports();
        }
    }
}
