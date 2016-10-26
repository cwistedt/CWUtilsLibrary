using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Builder.BuilderCar
{
    interface ICarBuilder
    {
        void SetColour(string colour);

        void SetWheels(int count);

        Car GetResult();
    }
}
