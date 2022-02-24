using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
     class DayOFWeek
    {
        public static void main(string[] args)
        {
            Console.WriteLine("New Plan Show Day of WeeK");
            Console.WriteLine("Enter Day");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int Y = Convert.ToInt32(Console.ReadLine());
            SetWeek(D, M, Y);
        }
            public static void SetWeek(int D, int M, int Y)
          {
            int y1 = Y - (14 - M) / 12;
            int x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            int m1 = M + 12 * ((14 - M) / 12) - 2;
            int d1 = (D + x + 31 * m1 / 12) % 7;

            switch (d1)
            {
                case 0:
                    Console.WriteLine("Ssunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
