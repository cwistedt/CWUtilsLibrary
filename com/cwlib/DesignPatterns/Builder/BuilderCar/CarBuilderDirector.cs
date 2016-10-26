using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Builder.BuilderCar
{
    class CarBuilderDirector
    {
        public Car Construct()
        {
            CarBuilder builder = new CarBuilder();

            builder.SetColour("Red");
            builder.SetWheels(4);

            return builder.GetResult();
        }
    }
}
