using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodPlan
{
    abstract class Plan
    {
        protected double rate;
        public abstract void getRate();

        public void calculateBill(int units)
        {
            Console.WriteLine(units * rate);
        }
    }
}
