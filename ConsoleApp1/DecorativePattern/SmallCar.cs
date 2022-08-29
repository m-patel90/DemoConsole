using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecorativePattern
{
    public class SmallCar : CarAbstract
    {
        public override int CarPrice()
        {
            return 1000;
        }

        public override string GetCarName()
        {
            return "Santro";
        }
    }
}
