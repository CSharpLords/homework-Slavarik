﻿using System;
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
            if (age >= 10)
            {
                if (age < 20)
                {
                    Console.WriteLine("Вы подросток");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Вы уже слишком стар");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("У вас ещё вся жизнь впереди");
                Console.ReadLine();
            }
        }
    }
}