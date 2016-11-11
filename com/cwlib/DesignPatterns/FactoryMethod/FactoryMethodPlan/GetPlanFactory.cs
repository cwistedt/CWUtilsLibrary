using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.FactoryMethod.FactoryMethodPlan
{
    class GetPlanFactory
    {
        /// <summary>
        /// The Factory Method
        /// </summary>
        /// <param name="planType"></param>
        /// <returns></returns>
        public Plan getPlan(string planType)
        {
            switch(planType)
            {
                case "DOMESTICPLAN":
                    return new DomesticPlan();
                    break;
                case "COMMERCIALPLAN":
                    return new CommercialPlan();
                    break;
                case "INSTITUTIONALPLAN":
                    return new InstitutionalPlan();
                    break;
                default:
                    throw new Exception("No such plan: " + planType);
                
            }
        }
    }
}
