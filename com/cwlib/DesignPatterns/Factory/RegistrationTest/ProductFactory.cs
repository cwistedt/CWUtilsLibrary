using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.RegistrationTest
{
    class ProductFactory
    {
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        private static ProductFactory instance;

        private ProductFactory()
        {

        }

        public static ProductFactory Instance()
        {
            if(instance == null)
            {
                instance = new ProductFactory();
            }

            return instance;
        }
            
        public void RegisterProduct(string key, Product product)
        {
            Console.WriteLine("Registered " + key);
            products.Add(key, product);
        }

        public Product CreateProduct(string key)
        {
            return products[key].CreateProduct();        
        }
    }
}
