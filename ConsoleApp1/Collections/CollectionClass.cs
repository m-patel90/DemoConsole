using System; 
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Collections
{
    public class CollectionClass
    {
        public void checkCollection()
        {
            string str22 = "ae";
            string sss = "aae";
            StringBuilder sb = new StringBuilder(sss);
            foreach (char cha1 in str22)
            {
                int aa1 = sss.IndexOf(cha1);
                sss = sss.Remove(aa1, 1);
                //sss = xyz;
            }

            int isInt;
            bool abc = int.TryParse("abc", out isInt);

            string str = "1 2 3 4 C D +";
            string[] strList = str.Split(" ");

            ArrayList arrayList1 = new ArrayList();
            for(int i=0; i < strList.Length; i++)
            {
                if(strList[i] == "D")
                {
                    arrayList1.Add(2 * Convert.ToInt32(arrayList1[arrayList1.Count -1]));
                } else if(strList[i] == "C")
                {
                    arrayList1.RemoveAt(i-1);
                } else if(strList[i] == "+")
                {
                    arrayList1.Add( Convert.ToInt32(arrayList1[arrayList1.Count - 1]) + Convert.ToInt32(arrayList1[arrayList1.Count - 2]));
                } else
                {
                    arrayList1.Add(strList[i]);
                }
            }

            
            //Array size and data type fixed
            int[] weight = new int[5] { 1,6,9,5,0};
            var data = weight.GroupBy(x => x).Where(y => y.Count() > 1).Select(s => s);
            weight.Min();
            weight.Max();

            var secondLast = weight.OrderByDescending(x => x).Skip(1).Take(1);

            string[] st = new[] { "rajesh|51|32|asd", "nitin|71|27|asd", "test|11|30|asd" };

            var data11 = weight.Where(x => x == 1).Select(y => y).OrderByDescending(c =>c);
            Array.Reverse(weight);

            //Swap array value position
            int swapindex = 0;
            int temp = 0;
            for(int i=0; i < weight.Length; i++)
            {
                swapindex = weight.Length -1;
                if (i == 0)
                {
                    temp = weight[i];
                    weight[i] = weight[swapindex];
                    weight[swapindex] = temp;
                }
            }

            //ArrayList - Non Generic collection. Size not fixed. support different type data
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("xyz");
            arrayList.Add(true);
            foreach (var data1 in arrayList)
            {
                Console.WriteLine(data1);
            }

            //List - Generic collection
            List<string> cityList = new List<string>();
            cityList.Add("London");
            cityList.Add("Mimbai");
            cityList.Add("Mimbai");

            List<string> areaCityList = new List<string>();
            areaCityList.Add("bkc");

            cityList.AddRange(areaCityList);
            cityList.Concat(areaCityList);

            //var data = cityList.GroupBy(x => x)
            //            .Where(y => y.Count() > 1)
            //            .Select(z => z.Key);
        }
    }
}
