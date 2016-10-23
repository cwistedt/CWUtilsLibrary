using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.DesignPatterns.FlyWeightMyTest
{
    class MetallicMoney : IMoney
    {
        public EnMoneyType MoneyType
        {
            get
            {
                return EnMoneyType.Metallic;
            }
        }

        public void GetDisplayOfMoneyFalling(int moneyValue)
        {
            // This method would display graphical representation of a metallic currency like a gold coin.
            Console.WriteLine(string.Format("Display a graphical object of {0} currency of value ${1} falling from the sky", MoneyType.ToString(), moneyValue));
        }
    }   
}
