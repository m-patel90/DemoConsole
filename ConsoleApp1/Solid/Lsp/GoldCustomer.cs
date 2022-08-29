using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Solid.Lsp
{
    public class GoldCustomer : Customer
    {
        public override int Discount(int sales)
        {
            return sales - 50;
        }
    }
}
