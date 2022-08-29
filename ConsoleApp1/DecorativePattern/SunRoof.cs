using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecorativePattern
{
    public class SunRoof : CarDecorator
    {
        public SunRoof(CarAbstract car) : base(car)
        {
        }

        public override int CarPrice()
        {
            return base.CarPrice() + 2000;
        }

        public override string GetCarName()
        {
            return "Santro with sunRoof";
        }
    }
}
