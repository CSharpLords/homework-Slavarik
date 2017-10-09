using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст");
            int age = int.Parse(Console.ReadLine());
            int number = 10;
            int number1 = 20;
            if (number <= age)
            {
                Console.WriteLine("Вы подросток");
                Console.ReadLine();
                if ( number1 > age)
                {
                    Console.WriteLine("Вы не подросток");
                    Console.ReadLine();
                }
            }
        }
    }
}
