using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyShape rect = new MyRectangle() { Width = 10, Height = 10 };
            Console.WriteLine($"方形的面積是 {rect.GetArea()}");
            MyShape circle = new MyCircle() { Radius = 3 };
            Console.WriteLine($"圓形的面積是 {circle.GetArea()}");
            /*
            雖然抽象類別可以擁有抽象的成員，但未必每個成員都需要宣告成抽象的。它也可以擁有一般的成員。 
            欄位沒有抽象這回事。
            你可以試著寫 MyShape shape = new MyShape();看看會發生甚麼事。
            */

            Console.ReadLine();
        }

        

    }

    ///<summary>
    /// 宣告一個抽象類別
    /// </summary>
    /* 甚麼是抽象?
     * 抽象類是指在 class 前加了 abstract 關鍵字且存在抽象方法（在類方法 function 關鍵字前加了 abstract 關鍵字）的類。
     * 要注意抽象類不能被直接實例化。抽象類中只定義（或部分實現）子類需要的方法。子類可以通過繼承抽象類並通過實現抽象類中的所有抽象方法，使抽象類具體化。
    */
    public abstract class MyShape
    {
        ///<summary>
        /// 宣告一個抽象方法
        /// </summary>
        public abstract double GetArea();

    }
    public class MyRectangle : MyShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class MyCircle : MyShape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
            /*
             * (1) Math.PI 是一個唯讀欄位，代表 π
             * (2) Math.Pow 是一個靜態方法，代表乘冪運算 (就是x 的 y 次方這種)

            */
        }
    }






}
