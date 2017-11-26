using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите грузоподъёмность НЛО:");
            int a = int.Parse(Console.ReadLine());
            int SumWheithCow = 0;
            int cow = 0;
            while (true)
            {
                Console.WriteLine("Введите массу коровы");
                int b = int.Parse(Console.ReadLine());
                SumWheithCow = b + SumWheithCow;
                if (a <= SumWheithCow)
                {
                    Console.WriteLine("Отсек для коров заполнен, взлетаем!Количество коров=" + cow);
                    break;
                }
                cow = cow + 1;
            }
            Console.ReadLine();

        }
    }
}
