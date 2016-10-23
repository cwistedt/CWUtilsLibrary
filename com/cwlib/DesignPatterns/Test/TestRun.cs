using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.cwlib.DesignPatterns.Flyweight.FlyweightMoney;
using com.cwlib.DesignPatterns.Flyweight.FlyweightUserCache;


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
                default:
                    Console.WriteLine("Design Pattern " + designPattern + " does not exists");
                    break;
            }

        }

        private void FlyweightUserCache()
        {
            FlyweightUserFactory fwuf = new FlyweightUserFactory();

            Guid guid_1 = new Guid();
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

    }
}
