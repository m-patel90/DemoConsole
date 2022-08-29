using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Polymorephism
{
    public class OverLoading
    {
        public string GetName(int a)
        {
            return "xyz";
        }

        public int GetName(int a, int b)
        {
            return 123;
        }
    }

    class B
    {
        public int GetName(int a,int b)
        {
            return 123;
        }
    }
}
