using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //合法的多載
            var x = Add(1, 2); Console.WriteLine($"合法的多載x={x}");
            x = Add(1, 2, 3); Console.WriteLine($"合法的多載x={x}");
            var s = Add("3", 3); Console.WriteLine($"合法的多載s= {s}");

            Console.ReadLine();
        }

        //合法的多載
        static int Add(int x, int y)
        { return x + y; }
        static int Add(int x, int y, int z)
        { return x + y + z; }
        static double Add(double x, double y)
        { return x + y; }
        static string Add(string x, string y)
        { return x + y; }
        static string Add(string x, int y)
        { return x + "整數" + y.ToString(); }
    }
}
