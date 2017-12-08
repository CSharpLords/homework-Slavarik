using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Растояние
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 1;
            int Large = 0;
            int Max = 0;
            while (Number < 11)
            {
                Console.WriteLine("Введите растояние до города №" + Number);
                Large = int.Parse(Console.ReadLine());
                Number = Number + 1;
                if (Large > Max)
                {
                    Max = Large;
                }
            }
            Console.WriteLine("Растояние до самого удалённого города:" + Max);
            Console.ReadLine();
        }
    }
}