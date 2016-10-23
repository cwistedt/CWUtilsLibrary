using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.DesignPatterns.FlyWeightMyTest
{

    public enum EnMoneyType { Metallic, Paper }
    interface IMoney
    {
        EnMoneyType MoneyType { get; }

        void GetDisplayOfMoneyFalling(int moneyValue);        
    }
}
