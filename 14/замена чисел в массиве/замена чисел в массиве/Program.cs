using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace замена_чисел_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = { 10, 5, 1, 3 };
            Console.WriteLine("Изначальный массив:");
            foreach (int i in massiv)
                Console.WriteLine(i+ " ");
            Console.WriteLine();
            Console.WriteLine("Введите номер элемента массива");
            int digit = int.Parse(Console.ReadLine());
            Console.Write("Введите новое значение массива:");
            int number = int.Parse(Console.ReadLine());
            massiv[digit] = number; Console.WriteLine();
            Console.WriteLine("Конечный массив");
            foreach (int i in massiv)
                Console.WriteLine(i+ " ");
            Console.ReadLine();
        }
    }
}
