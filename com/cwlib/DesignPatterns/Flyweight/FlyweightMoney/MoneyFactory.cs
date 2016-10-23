using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.DesignPatterns.FlyWeightMyTest
{
    class MoneyFactory
    {
        public static int ObjectsCount = 0;
        private Dictionary<EnMoneyType, IMoney> _moneyObjects;
        
        /// <summary>
        /// Same as GetFlyweight
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IMoney GetMoneyToDisplay(EnMoneyType form)
        {
            if(_moneyObjects == null)
            {
                _moneyObjects = new Dictionary<EnMoneyType, IMoney>();
            }
            if(_moneyObjects.ContainsKey(form))
            {
                return _moneyObjects[form];
            }

            switch(form)
            {
                case EnMoneyType.Metallic:
                    _moneyObjects.Add(form, new MetallicMoney());
                    ObjectsCount++;
                    break;
                case EnMoneyType.Paper:
                    _moneyObjects.Add(form, new PaperMoney());
                    ObjectsCount++;
                    break;
                default:
                    break;
            }

            return _moneyObjects[form];
        }
    }
}
