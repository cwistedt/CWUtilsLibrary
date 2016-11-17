using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.RegistrationTest
{
    abstract class Product
    {
        public abstract Product CreateProduct();
    }
}
