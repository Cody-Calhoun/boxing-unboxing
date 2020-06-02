using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxingandUnboxing
{

    class Program
    {
        static void Main(string[] args)
        {
            List<object> listy = new List<object>();
            listy.Add(7);
            listy.Add(28);
            listy.Add(-1);
            listy.Add(true);
            listy.Add("Chair");

            // int AddNumbers(IEnumerable<object> listy)
            {
                int sum = 0;
                foreach (object item in listy)
                {

                    if (item is int)
                    {
                        System.Console.WriteLine("number");
                        sum = (sum+(int)item);
                    }
                    if (item is bool)
                    {
                        System.Console.WriteLine("World");
                    }
                    if (item is string)
                    {
                        System.Console.WriteLine("Hello");
                    }
                }
                System.Console.WriteLine(sum);
            }





        }
    }
}
