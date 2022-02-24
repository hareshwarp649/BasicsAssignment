using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class ToBinnary
    {
        public static void BinnaryTo ()
        {
            Console.WriteLine("decimal to binary");
            Console.WriteLine("enetr number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            List<int> binaryList = new List<int>();

            int power2 = 2;
            while (num > power2)
            {
                power2 *= 2;
            }

            while (power2 > 0)
            {
                
                
                if (num >= power2)
                {
                    num -= power2;
                    binaryList.Add(1);
                }
                else
                {
                    binaryList.Add(0);
                }
                power2 /= 2;
            }

            Console.WriteLine(string.Join(" ", binaryList));
        }
    }
}
