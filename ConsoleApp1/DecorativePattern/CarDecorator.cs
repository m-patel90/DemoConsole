using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecorativePattern
{
    public class CarDecorator : CarAbstract
    {
        protected CarAbstract _car;
        public CarDecorator(CarAbstract car)
        {
            _car = car;
        }

        public override int CarPrice()
        {
            return _car.CarPrice();
        }

        public override string GetCarName()
        {
            return _car.GetCarName();
        }
    }
}
