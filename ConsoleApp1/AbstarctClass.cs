using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class AbstarctClass
    {
        public int xyz { get; set; }
        protected string newstring;
        public abstract string print();

        public AbstarctClass(string a)
        {
            newstring = a;
        }
        public virtual string NonAbstractMethod()
        {
            return "Non abstract method";
        }
    }
}
