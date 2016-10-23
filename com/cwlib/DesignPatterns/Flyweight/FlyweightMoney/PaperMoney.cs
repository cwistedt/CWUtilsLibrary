using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Flyweight.FlyweightMoney
{
    class PaperMoney : IMoney
    {
        public EnMoneyType MoneyType
        {
            get { return EnMoneyType.Paper; }
        }

        public void GetDisplayOfMoneyFalling(int moneyValue)
        {
            // This would display a graphical representation of a paper currency falling
            Console.WriteLine(string.Format("Displaying a graphical object of {0} currency of value ${1} fallling from sky", MoneyType.ToString(), moneyValue));
        }
    }
}
