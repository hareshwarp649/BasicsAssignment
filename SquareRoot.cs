using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class SquareRoot
    {
        public static void RootSquare()
        {
            Console.WriteLine("Calculate Square Root using Newtons Method");
            Console.WriteLine("Enter number");
            double num = Convert.ToDouble(Console.ReadLine());

            double t = num;

            while ((Math.Abs(t - num / t)) > (1e-15 * t))
            {
                t = (t + (num / t)) / 2;
            }
            Console.WriteLine("Square Root Num \n" + t);
        }
     
    }
}
