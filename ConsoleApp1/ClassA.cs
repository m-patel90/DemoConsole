using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassA : AbstarctClass
    {
        public ClassA(string aaa): base(aaa)
        {
            name = aaa;
            Console.WriteLine("Derives classA constructor");
        }
        public string name { get; set; }
        protected string EmployeeName { get; set; }

        public override string print()
        {
            Console.WriteLine(newstring);
            return newstring;
            //throw new NotImplementedException();
        }


        public string getname(int a)
        {
            Console.WriteLine("Class A");
            return "aaa";
        }

        public bool IsValid(string data)
        {
            return true;
        }

        public override string NonAbstractMethod()
        {
            return "Class A over right implementation";
        }
    }


    public class ClassB : ClassA
    {
        static ClassB()
        {
            Console.WriteLine("Static contrcurot");
        }
        public ClassB() : base("a")
        {
            Console.WriteLine("Derives classB constructor");
        }

        public void getxyz()
        {
            EmployeeName = "Maulik Patel";
            //getname();
            base.name = "Maulik";

            print();
        }

        public string IsValid;

        public string getname(int a)
        {
            Console.WriteLine("Class B");
            return "aaa";
        }
    }

    public class ClassC: ClassB
    {
        public ClassC()
        {

        }

        public string GetEmployeeName()
        {
            return EmployeeName;
        }
    }
        
}
