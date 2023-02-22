using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEx
{
    /// <summary>
    /// 虛擬
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new Class1();
            o1.Execute();
            o1.Begin();

            BaseClass o2 = new Class2();
            o2.Execute();
            o2.Begin();


            //合法的多載
            var x = Add(1, 2); Console.WriteLine($"合法的多載x={x}");
            x= Add(1, 2, 3); Console.WriteLine($"合法的多載x={x}");
            var s= Add("3", 3); Console.WriteLine($"合法的多載s= {s}");

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

    public class BaseClass
    {
        public virtual void Execute()
        {
            Console.WriteLine("BaseClass Execute Method");
        }
        public virtual void Begin()
        {
            Console.WriteLine("BaseClass Begin Method");
        }

    }

    public class Class1 : BaseClass
    {
        public override void Execute()
        {
            //base.Execute();
            Console.WriteLine("Class1 Execute Method");

        }
    }

    public class Class2 : Class1
    {
        public override sealed void Execute()
        {
            Console.WriteLine("Class2 Execute Method");
        }
        public override void Begin()
        {
            Console.WriteLine("Class2 Begin Method");
        }
        /* (1)這表示父類別(Class1)的方法(Exectue())若為 override，子類別(Class2) 一樣可以覆寫
         * (2)若祖父類別(BaseClass)的方法(Begin())若為 virtual/override，而父類別(Class1)雖然沒有覆寫，但子類別(Class2)一樣可以覆寫
        */
    }

    public class Class3 : Class2
    {
        public override void Begin()
        {
            Console.WriteLine("OK");
        }
    }



}
