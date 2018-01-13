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
            while (next < numbers.Length)
            {
                if (numbers[0] > 0 && numbers[1] > 0 || numbers[0] < 0 && numbers[1] < 0)
                {
                    Console.WriteLine(numbers[0] + "" + numbers[1]);
                }
            }
            Console.ReadLine();
        }
    }
}
