using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodPlan
{
    class DomesticPlan: Plan
    {
        public override void getRate()
        {
            rate = 3.50;
        }        
    }
}
