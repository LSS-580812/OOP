using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MyRectangle
    {
        public double width { get; set; }
        public double height { get; set; }

        public double GetArea()
        {
            return width * height;
        }
    }

}
