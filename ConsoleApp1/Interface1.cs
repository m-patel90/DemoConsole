using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface Interface1
    {
        //int xyz { get; set; }

        void print();
    }

    interface Interface2
    {
        void print();
    }

    class xyz : Interface1, Interface2
    {
        void Interface1.print()
        {
            Console.WriteLine("Interface1 implementation");
        }

        void Interface2.print()
        {
            Console.WriteLine("Interface2 implementation");
        }
    }
}
