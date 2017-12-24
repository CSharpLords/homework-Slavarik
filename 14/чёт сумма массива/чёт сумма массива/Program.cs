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
            int sum = 0;
            int[] massiv = { 10, 5, 1, 3, 4 };
            for (int quantum = 0; quantum < massiv.Length; quantum = quantum + 1)
            {
                sum = sum + massiv[quantum];
            }
            int remainder = sum % 2;
            if (remainder == 0)
            {
                Console.WriteLine("Сумма элементов в массиве является чётным числом");
            }
            else
            {
                Console.WriteLine("Сумма элементов в массиве является нечётным числом!");
            }
            Console.ReadLine();
        }
    }
}