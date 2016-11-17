using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.RegistrationTest
{
    class OneProduct : Product
    {
        public static void Touch()
        {

        }
        static OneProduct()
        {
            ProductFactory.Instance().RegisterProduct("OneProduct", new OneProduct());
        }
        
        private OneProduct()
        {
            Console.WriteLine("Created OneProduct");
        }

        public override Product CreateProduct()
        {
            return new OneProduct();
        }
    }
}
