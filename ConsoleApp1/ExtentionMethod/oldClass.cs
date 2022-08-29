using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ExtentionMethod
{
    public class oldClass
    {
        int value;
        int value1 = 10;
        public void A()
        {
            

        }

        public void B(ref int value1,  out int value)
        {
            value = value1 + 10;
            value1 += value;
        }
    }
}
