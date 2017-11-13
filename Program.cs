using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        public static void Main(string []args)
        {
            MyMath calc = new MyMath();
            calc.Add(3.45, 4.29);
            Console.WriteLine("Add: " + calc.GetResult());

            
            calc.Subtract(9.75, 4.29);
            Console.WriteLine("Subtract: " + calc.GetResult());

     
            calc.Divide(200, 4.5);
            Console.WriteLine("Divide: " + calc.GetResult());

       
            calc.Multiply(22.6, 76.5);
            Console.WriteLine("Multiply: " + calc.GetResult());


        }
    }
}
