using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecorativePattern
{
    public class AdvanceMusic : CarDecorator
    {
        public AdvanceMusic(CarAbstract car) : base(car)
        {
        }

        public override int CarPrice()
        {
            return _car.CarPrice() + 3000;
        }

        public override string GetCarName()
        {
            return "Santro with Advcanc Music";
        }
    }
}
