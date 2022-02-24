using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class TempConve
    {
        public static void ConvertTemp()
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("Enter 1: Celsius to Fahrenheit    2: Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Temperature");
            int temp = Convert.ToInt32(Console.ReadLine());


            if(option==1)
            {
               int f= (temp * 9 / 5) + 32;
                Console.WriteLine($"{f} fahrenheit");
            }
            else if (option==2)
            {
                int c= (temp - 32) * 5 / 9;
                Console.WriteLine($"{c} celsius");
                
            }else
            {
                Console.WriteLine("Wrong Choice");

            }
        }
    }
}
