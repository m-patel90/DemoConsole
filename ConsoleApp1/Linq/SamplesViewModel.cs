using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Linq
{
    public class SamplesViewModel
    {
        public List<Product> products { get; set; }
        public List<SalesOrderDetail> sales { get; set; }
        public string ResultText { get; set; }

        public bool UseQuerySyntaxt { get; set; } = true;
        public SamplesViewModel()
        {
            products = ProductRepository.GetAll();
            sales = SalesOrderDetailRepository.GetAll();
        }


        public void GetAllLooping()
        {
            List<Product> listproduct = new List<Product>();
            foreach (Product item in products)
            {
                listproduct.Add(item);
            }
            ResultText = $"Result" + listproduct.Count;
        }

        public void All()
        {
            List<Product> list;
            if (UseQuerySyntaxt)
            {
                list = (from prod in products
                        select prod).ToList();
            }
            else
            {
                list = products.Select(x => x).ToList();
            }
        }

        public void GetSingleColumn()
        {
            StringBuilder sb = new StringBuilder(1024);
            List<string> singleList = new List<string>();
            if (UseQuerySyntaxt)
            {
                singleList.AddRange(from prod in products
                                    select prod.Name);
            }
            else
            {//Method Syntax
                singleList.AddRange(products.Select(x => x.Name));
            }

            foreach (string item in singleList)
            {
                sb.Append(item);
            }
            ResultText = $"Total Products: {singleList.Count}" + Environment.NewLine + sb.ToString();
        }

        public void GetSpecificColumns()
        {
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            select new Product
                            {
                                ProductID = prod.ProductID,
                                Name = prod.Name,
                                Color = prod.Color
                            }).ToList();
            }
            else
            {
                products = products.Select(x => new Product
                {
                    ProductID = x.ProductID,
                    Name = x.Name,
                    Color = x.Color
                }).ToList();
            }
            ResultText = $"Total Products: {products.Count}";
        }

        public void AnonymousClass()
        {
            StringBuilder sb = new StringBuilder(1024);
            if (UseQuerySyntaxt)
            {
                var data = (from prod in products
                            select new
                            {
                                Id = prod.ProductID,
                                PName = prod.Name,
                                Pcolor = prod.Color
                            }).ToList();

                foreach (var item in data)
                {
                    sb.Append($"Product Id:{item.Id}");
                    sb.Append($"Product Name:{item.PName}");
                    sb.Append($"Product Color:{item.Pcolor}");
                }
            }
            else
            {
                var data = products.Select(x => new
                {
                    Id = x.ProductID,
                    PName = x.Name,
                    Pcolor = x.Color
                }).ToList();

                foreach (var item in data)
                {
                    sb.Append($"Product Id:{item.Id}");
                    sb.Append($"Product Name:{item.PName}");
                    sb.Append($"Product Color:{item.Pcolor}");
                }
            }
            ResultText = sb.ToString();
            products.Clear();
        }

        public void OrderBy()
        {
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            orderby prod.Name descending
                            select prod).ToList(); ;
            }
            else
            {
                products = products.OrderByDescending(x => x.Name).ToList();
            }
            ResultText = $"Total Products: {products.Count}";
        }

        public void OrderByTwoFields()
        {
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            orderby prod.Color descending, prod.Name
                            select prod).ToList(); ;
            }
            else
            {
                products = products.OrderByDescending(x => x.Color)
                    .ThenBy(x => x.Name).ToList();
            }
            ResultText = $"Total Products: {products.Count}";
        }

        public void WhereExpression()
        {
            string search = "L";
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            where prod.Name.StartsWith(search)
                            select prod).ToList();
            }
            else
            {
                products = products.Where(x => x.Name.StartsWith(search)).ToList();
            }
            ResultText = $"Total Products: {products.Count}";
        }

        public void WhereTwoFields()
        {
            string search = "L";
            decimal cost = 100;
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            where prod.Name.StartsWith(search) && prod.StandardCost > cost
                            select prod).ToList();
            }
            else
            {
                products = products.Where(x => x.Name.StartsWith(search) && x.StandardCost > cost).ToList();
            }
            ResultText = $"Total Products: {products.Count}";
        }

        public void WhereExtentionMethod()
        {
            string search = "Red";
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            select prod).ByColor(search).ToList();
            }
            else
            {
                products = products.ByColor(search).ToList();
            }
            ResultText = $"Total Products: {products.Count}";
        }

        #region First
        /// <summary>
        /// Locate a specific product using First(). First() searches forward in the collection.
        /// NOTE: First() throws an exception if the result does not produce any values
        /// </summary>
        public void First()
        {
            string search = "Red";
            Product value;
            try
            {
                if (UseQuerySyntaxt)
                {
                    value = (from prod in products
                             select prod).First(prod => prod.Color == search);
                }
                else
                {
                    value = products.First(x => x.Color == search);
                }
                ResultText = $"Found: {value}";
            }
            catch (Exception)
            {
                ResultText = "Not found";
            }
            products.Clear();
        }
        #endregion

        #region FirstOrDefault
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: FirstOrDefault() returns a null if no value is found
        /// </summary>
        public void FirstOrDefault()
        {
            string search = "Red";
            Product value;

            if (UseQuerySyntaxt)
            {
                value = (from prod in products
                         select prod).FirstOrDefault(prod => prod.Color == search);
            }
            else
            {
                value = products.FirstOrDefault(x => x.Color == search);
            }

            if (value == null)
            {
                ResultText = "Not Found";
            }
            else
            {
                ResultText = $"Found {value}";
            }
        }
        #endregion

        #region Last
        /// <summary>
        /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
        /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
        /// </summary>
        public void Last()
        {
            string search = "Red";
            Product value;
            try
            {
                if (UseQuerySyntaxt)
                {
                    value = (from prod in products
                             select prod).Last(prod => prod.Color == search);
                }
                else
                {
                    value = products.Last(x => x.Color == search);
                }

                ResultText = $"Found: {value}";
            }
            catch (Exception)
            {
                ResultText = "Not Found";
            }
        }
        #endregion

        #region LastOrDefault
        /// <summary>
        /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
        /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
        /// </summary>
        public void LastOrDefault()
        {
            string search = "Red";
            Product value;
            if (UseQuerySyntaxt)
            {
                value = (from prod in products
                         select prod).LastOrDefault(prod => prod.Color == search);
            }
            else
            {
                value = products.LastOrDefault(x => x.Color == search);
            }

            if (value == null)
            {
                ResultText = "Not Found";
            }
            else
            {
                ResultText = $"Found: {value}";
            }
        }
        #endregion

        #region Single
        /// <summary>
        /// Locate a specific product using Single().
        /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
        /// </summary>
        public void Single()
        {
            int search = 706;
            Product value;
            try
            {
                if (UseQuerySyntaxt)
                {
                    value = (from pro in products
                             select pro).Single(pro => pro.ProductID == search);
                }
                else
                {
                    value = products.Single(x => x.ProductID == search);
                }
                ResultText = $"Found: {value}";
            }
            catch (Exception)
            {
                ResultText = "Not Found, or multiple elements found";
            }
        }
        #endregion

        #region SingleOrDefault
        /// <summary>
        /// Locate a specific product using SingleOrDefault()
        /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
        /// </summary>
        public void SingleOrDefault()
        {
            int search = 706;
            Product value;
            try
            {
                if (UseQuerySyntaxt)
                {
                    value = (from pro in products
                             select pro).SingleOrDefault(pro => pro.ProductID == search);
                }
                else
                {
                    value = products.SingleOrDefault(x => x.ProductID == search);
                }
                ResultText = $"Found: {value}";

                if (value == null)
                {
                    ResultText = "Not Found";
                }
                else
                {
                    ResultText = $"Found: {value}";
                }
            }
            catch (Exception)
            {
                ResultText = "Multiple elements found";
            }
        }
        #endregion

        #region ForEach Method
        /// <summary>
        /// ForEach allows you to iterate over a collection to perform assignments within each object.
        /// In this sample, assign the Length of the Name property to a property called NameLength
        /// When using the Query syntax, assign the result to a temporary variable.
        /// </summary>
        public void ForEach()
        {
            if (UseQuerySyntaxt)
            {
                products = (from prod in products
                            let temp = prod.NameLength = prod.Name.Length
                            select prod).ToList();
            }
            else
            {
                products.ForEach(x => x.NameLength = x.Name.Length);
            }
        }
        #endregion

        #region ForEachCallingMethod Method
        /// <summary>
        /// Iterate over each object in the collection and call a method to set a property
        /// This method passes in each Product object into the SalesForProduct() method
        /// In the SalesForProduct() method, the total sales for each Product is calculated
        /// The total is placed into each Product objects' ResultText property
        /// </summary>
        public void ForEachCallingMethod()
        {
            if (UseQuerySyntaxt)
            {
                // Query Syntax
                products = (from prod in products
                            let temp = prod.TotalSales = SalesForProduct(prod)
                            select prod
                            ).ToList();
            }
            else
            {
                // Method Syntax
                products.ForEach(x => x.TotalSales = SalesForProduct(x));
            }

            ResultText = $"Total Products: {products.Count}";
        }
        /// <summary>
        /// Helper method called by LINQ to sum sales for a product
        /// </summary>
        /// <param name="prod">A product</param>
        /// <returns>Total Sales for Product</returns>
        private decimal SalesForProduct(Product prod)
        {
            return sales.Where(sale => sale.ProductID == prod.ProductID)
                   .Sum(sale => sale.LineTotal);
        }
        #endregion

        #region Take Method
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public void Take()
        {
            if (UseQuerySyntaxt)
            {
                // Query Syntax
                products = (from prod in products
                            orderby prod.Name
                            select prod
                            ).Take(5).ToList();

                products = (from prod in products
                            orderby prod.Name
                            select prod
                            ).TakeWhile(prod => prod.Name.StartsWith("A")).ToList();

                products = (from prod in products
                            orderby prod.Name
                            select prod
                            ).Skip(5).ToList();
            }
            else
            {
                // Method Syntax
                products = products.OrderBy(x => x.Name).Take(5).ToList();
                products = products.OrderBy(x => x.Name).TakeWhile(x => x.TotalSales > 100).ToList();
            }

            ResultText = $"Total Products: {products.Count}";
        }
        #endregion

        #region All
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public void AllIteams()
        {
            string search = " ";
            bool value;

            if (UseQuerySyntaxt)
            {
                // Query Syntax
                value = (from prod in products
                         select prod).Any(prod => prod.Name.Contains(search));
            }
            else
            {
                // Method Syntax
                value = products.Any(x => x.Name.Contains(search));
            }

            ResultText = $"Do all Name properties contain a '{search}'? {value}";

            // Clear List
            products.Clear();
        }
        #endregion

        #region LINQContains
        /// <summary>
        /// Use the LINQ Contains operator to see if a collection contains a specific value
        /// </summary>
        public void LINQContains()
        {
            bool value;
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            if (UseQuerySyntaxt)
            {
                // Query Syntax
                value = (from num in numbers
                         select num).Contains(3);
            }
            else
            {
                // Method Syntax
                value = numbers.Contains(3);
            }

            ResultText = $"Is the number in collection? {value}";

            // Clear List
            products.Clear();
        }
        #endregion

        #region Union
        /// <summary>
        /// Union() combines two lists together, but skips duplicates by using a comparer class
        /// This is like the UNION SQL operator
        /// </summary>
        public void Union()
        {
            //ProductComparer pc = new ProductComparer();
            // Load all Product Data
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data
            List<Product> list2 = ProductRepository.GetAll();

            if (UseQuerySyntaxt)
            {
                // Query Syntax
                products = (from prod in list1
                            select prod)
                            .Union(list2)
                            .OrderBy(prod => prod.Name).ToList();
            }
            else
            {
                // Method Syntax
                products = list1.Concat(list2)
                                .OrderBy(prod => prod.Name).ToList();
            }

            ResultText = $"Total Products: {products.Count}";
        }
        #endregion

        #region InnerJoin
        /// <summary>
        /// Join a Sales Order Detail collection with Products into anonymous class
        /// NOTE: This is an equijoin or an inner join
        /// </summary>
        public void InnerJoin()
        {
            StringBuilder sb = new StringBuilder(2048);
            int count = 0;

            if (UseQuerySyntaxt)
            {
                // Query syntax
                var query = from prod in products
                            join sale in sales
                            on prod.ProductID equals sale.ProductID
                            select new
                            {
                                prod.ProductID,
                                prod.Name,
                                sale.SalesOrderID,
                                sale.OrderQty
                            };

                foreach (var item in query)
                {
                    count++;
                    sb.AppendLine($"Sales Order: {item.SalesOrderID}");
                    sb.AppendLine($"  Product ID: {item.ProductID}");
                    sb.AppendLine($"  Product Name: {item.Name}");
                    //sb.AppendLine($"  Size: {item.Size}");
                    sb.AppendLine($"  Order Qty: {item.OrderQty}");
                    //sb.AppendLine($"  Total: {item.LineTotal:c}");
                }
            }
            else
            {
                // Method syntax
                var query = products.Join(sales, x => x.ProductID,
           y => y.ProductID,
           (x, y) => new
           {
               x.ProductID,
               x.Name,
               x.Color,
               x.StandardCost,
               x.ListPrice,
               x.Size,
               y.SalesOrderID,
               y.OrderQty,
               y.UnitPrice,
               y.LineTotal
           });

                foreach (var item in query)
                {
                    count++;
                    sb.AppendLine($"Sales Order: {item.SalesOrderID}");
                    sb.AppendLine($"  Product ID: {item.ProductID}");
                    sb.AppendLine($"  Product Name: {item.Name}");
                    sb.AppendLine($"  Size: {item.Size}");
                    sb.AppendLine($"  Order Qty: {item.OrderQty}");
                    sb.AppendLine($"  Total: {item.LineTotal:c}");
                }
            }

            ResultText = sb.ToString() + Environment.NewLine + "Total Sales: " + count.ToString();
        }
        #endregion
    }
}
