using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Flyweight.FlyweightMoney
{

    public enum EnMoneyType { Metallic, Paper }
    public interface IMoney
    {
        EnMoneyType MoneyType { get; }

        void GetDisplayOfMoneyFalling(int moneyValue);        
    }
}
