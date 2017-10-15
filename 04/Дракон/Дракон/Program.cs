using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи возраст дракона");
            int age = int.Parse(Console.ReadLine());
            if (age < 150)
            {
                Console.WriteLine("Поздравляю!!!Вам попался молодой дракон");
                Console.WriteLine("Введите его hp");
                int hp = int.Parse(Console.ReadLine());
                if (hp < 50)
                {
                    Console.WriteLine("Поздравляю с победой,юный рыцарь!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Слишком много hp,попытайся сбежать");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Лучше не подходить к дракону,он слишком мудр");
                Console.ReadLine();
            }
                
        }
    }
}
