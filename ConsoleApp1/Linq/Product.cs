using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Linq
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        
        public int? NameLength { get; set; }
        public decimal? TotalSales { get; set; }
    }
}
