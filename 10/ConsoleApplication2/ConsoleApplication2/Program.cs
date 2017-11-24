using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число:");
                int a = int.Parse(Console.ReadLine());
                int b = a * a;
                Console.WriteLine("Квадрат числа равен:" + b);
                Console.ReadLine();
            }
        }
    }
}
