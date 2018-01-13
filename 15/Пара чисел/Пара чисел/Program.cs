using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Предыд_Числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 2, 2, 7 };
            int behind = 0;
            int next = 1;
            while (next < numbers.Length)
            {
                if (numbers[next] == numbers[behind])
                {
                    Console.WriteLine(numbers[next]);
                }
                behind = behind + 1;
                next = next + 1;
            }
            Console.ReadLine();
        }
    }
}