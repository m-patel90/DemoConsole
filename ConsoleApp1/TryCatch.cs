using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TryCatch
    {
        public void print()
        {
            try
            {
                var x = 10;
                dynamic s = "str";
                s.obj();
            }
            catch (Exception EX)
            {
                //throw EX;
                Console.WriteLine(EX.Message);
            }
            //catch (DivideByZeroException ex)
            //{

            //}
            finally
            {
                Console.WriteLine("FINALLY CALLED");
            }
        }
	}
}
