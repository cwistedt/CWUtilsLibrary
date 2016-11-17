using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Data;

using com.cwlib.DesignPatterns.Flyweight.FlyweightMoney;
using com.cwlib.DesignPatterns.Flyweight.FlyweightUserCache;
using com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryDatabase;
using com.cwlib.DesignPatterns.AbstractFactory.AbstractFactoryReport;
using com.cwlib.DesignPatterns.Builder.BuilderDatabase;
using com.cwlib.DesignPatterns.Builder.BuilderCar;
using com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodDatabase;
using com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodPlan;
using com.cwlib.DesignPatterns.Factory.RegistrationTest;
using com.cwlib.DesignPatterns.Factory.AutoRegistrationTest;

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
                case "AutoSelfRegistrationFactory":
                    Instance.AutoSelfRegistrationFactory();
                    break;
                case "RegistrationFactory":
                    Instance.RegistrationFactory();
                    break;
                case "FactoryMethodPlan":
                    Instance.FactoryMethodPlan();
                    break;
                case "FactoryMethodDB":
                    Instance.FactoryMethodDB("SQL");
                    Instance.FactoryMethodDB("OLEDB");
                    break;
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
                case "BuilderDatabase":
                    Instance.BuilderDatabase("SQL");
                    Instance.BuilderDatabase("OLEDB");
                    break;
                case "BuilderCar":
                    Instance.BuilderCar();
                    break;
                default:
                    Console.WriteLine("Design Pattern " + designPattern + " does not exists");
                    break;
            }

        }
        
        private void AutoSelfRegistrationFactory()
        {
            IEDI EDIVB = EDIFactory.Instance.GetEDI(EDITYPES.VB);
            IEDI EDIMP = EDIFactory.Instance.GetEDI(EDITYPES.MP);
        }

        private void RegistrationFactory()
        {
            OneProduct.Touch();
            Product product = ProductFactory.Instance().CreateProduct("OneProduct");
        }

        private void FactoryMethodPlan()
        {
            GetPlanFactory planFactory = new GetPlanFactory();

            Plan domesticPlan = planFactory.getPlan("DOMESTICPLAN");
            domesticPlan.getRate();
            Console.WriteLine("Bill amount for DOMESTICPLAN of  5 units is: ");
            domesticPlan.calculateBill(5);


            Plan commercialPlan = planFactory.getPlan("COMMERCIALPLAN");
            commercialPlan.getRate();
            Console.WriteLine("Bill amount for COMMERCIALPLAN of  5 units is: ");
            commercialPlan.calculateBill(5);

            Plan institutionalPlan = planFactory.getPlan("INSTITUTIONALPLAN");
            institutionalPlan.getRate();
            Console.WriteLine("Bill amount for INSTITUTIONALPLAN of  5 units is: ");
            institutionalPlan.calculateBill(5);
        }


        private void FactoryMethodDB(string type)
        {
            FactoryMethod.FactoryMethodDatabase.IDatabase database;
            FactoryMethod.FactoryMethodDatabase.DatabaseType databaseType;
            if (type == "OLEDB")
            {
                Console.WriteLine("Creating SqlServerDatabase");
                databaseType = FactoryMethod.FactoryMethodDatabase.DatabaseType.OleDb;
            }
            else
            {
                Console.WriteLine("Creating OleDBServerDatabase");
                databaseType = FactoryMethod.FactoryMethodDatabase.DatabaseType.OleDb;
            }

            //The FactoryMetod
            database = FactoryMethod.FactoryMethodDatabase.DatabaseFactory.CreateDatabase(databaseType);

            IDbCommand command = database.Command;
        }

        private void BuilderCar()
        {
            CarBuilderDirector carBuilderDirector = new CarBuilderDirector();
            Car car = carBuilderDirector.Construct();
            Console.WriteLine(car);
        }

        private void BuilderDatabase(string type)
        {
            Director director = new Director();
            IDatabaseBuilder builder;

            if (type == "SQL")
            {
                Console.WriteLine("Building SQL");
                builder = new SqlServerDatabaseBuilder();
            }
            else
            {
                Console.WriteLine("Building OLEDB");
                builder = new OleDbDatabaseBuilder();
            }
            
            director.Build(builder);
            Builder.BuilderDatabase.Database database = builder.Database;

            DbCommand command = database.Command;            
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
            AbstractFactory.AbstractFactoryDatabase.Database database;
            if (type == "SQL")
            {
                Console.WriteLine("Creating SqlServerDatabase");
                database = new AbstractFactory.AbstractFactoryDatabase.SqlServerDatabase();
            }
            else
            {
                Console.WriteLine("Creating OleDBDatabase");
                database = new AbstractFactory.AbstractFactoryDatabase.OleDBDatabase();
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
