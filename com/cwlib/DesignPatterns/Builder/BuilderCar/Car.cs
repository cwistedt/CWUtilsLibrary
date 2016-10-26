using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Builder.BuilderCar
{
    class Car
    {
        public Car()
        {

        }

        public int Wheels { get; set; }

        public string Colour { get; set; }

        public override string ToString()
        {
            return "Wheels " + Wheels + " Colour " + Colour;
        }
    }
}
