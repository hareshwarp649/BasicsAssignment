using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class MonthPay
    {
     public static void PayMonth()
        {
            double p, y, r, TotalPay;
            Console.WriteLine("calculate nthly payment");

            Console.WriteLine("Enter Principal Amount");
             p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter years");
             y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter percent interest");
             r = Convert.ToDouble(Console.ReadLine());

            TotalPay = p * (Math.Pow(1 + (r / 100), y));
            double EMI = TotalPay / (y * 12);
            Console.WriteLine("New Value :\n" + EMI);
        }
    }
}
