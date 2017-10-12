using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Кислород
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите состав кислорода в воздухе(в процентах)");
            int Oxygen = int.Parse(Console.ReadLine());
            if (Oxygen > 20)
            {
                Console.WriteLine("Напишите среднюю температуру воздуха");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("Отправляется сообщение");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Планета не пригодна для жизни");
                Console.ReadLine();
            }
        }
    }
}
