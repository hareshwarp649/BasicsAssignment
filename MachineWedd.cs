using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class MachineWedd
    {
        public static void WeddMachine()
        {
            Console.WriteLine("minimum number of notes to give change");
            int Num = Convert.ToInt32(Console.ReadLine());
            int remainder = Num;
            int[] Array = new int[8] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            foreach (int note in Array)
            {
                int i = 0;
                while (remainder >= note)
                {
                    remainder -= note;
                    i++;
                }
                string result = i > 0 ? $"{note} X {i} = {note * i}" : "-";
                Console.WriteLine(result);
            }
        }
    }
}
