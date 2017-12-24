using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полож_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 11, 5, -2, 3 };
            Console.WriteLine("Введите номер числа");
            int digit = int.Parse(Console.ReadLine());
            if (numbers[digit] < 0)
            {
                Console.WriteLine("Выбранное вами число отрицательное");
            }
            if (numbers[digit] > 0)
            {
                Console.WriteLine("Выбранное вами число  положительно");
            }
            Console.ReadLine();
        }
    }
}
