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
            int[] numbers = { -5, 6, -2, 2, -7 };
            int n = 0;
            int back = 0;
            int next = 1;
            while(n < 1)
            {
                if (numbers[back] > 0 && numbers[next] > 0 || numbers[back] < 0 && numbers[next] < 0 || numbers[back] == 0 && numbers[next] == 0)
                {
                    Console.WriteLine(numbers[back] + " " + numbers[next]);
                    n = n + 1;
                }
                back = back + 1;
                next = next + 1;
            }    

            Console.ReadLine();
        }
    }
}
