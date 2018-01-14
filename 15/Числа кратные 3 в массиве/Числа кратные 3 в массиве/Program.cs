using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Числа_кратные_3_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[60];
            int n = 0;
            int i = 60; 
            while(i > 10)
            {
                numbers[n] = i;
                Console.WriteLine(numbers[n]);
                i = i - 3;
            }
            Console.ReadLine();
        }   
    }
}
