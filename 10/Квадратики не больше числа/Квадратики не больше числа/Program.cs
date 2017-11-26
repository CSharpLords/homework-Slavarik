using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квадраты_натуральных_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int b = 1;
            Console.WriteLine("Квадраты не превышающие:" + n);
            while (true)
            {
                int c = b * b;
                b = b + 1;
                if (c <= n)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}