using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Builder.BuilderCar
{
    class CarBuilder : ICarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            this._car = new Car();
        }

        public void SetColour(string colour)
        {
            this._car.Colour = colour;
        }

        public void SetWheels(int count)
        {
            this._car.Wheels = count;
        }

        public Car GetResult()
        {
            return this._car;
        }
    }
}
