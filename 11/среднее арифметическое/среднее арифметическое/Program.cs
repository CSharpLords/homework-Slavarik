using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace среднее_арифметическое
{
    class Program
    {
        static void Main(string[] args)
        {
            int account = 0;
            int number = 0;
            int sum = 0;
            while(number < 50)
            {
                Thread.Sleep(100);
                Random rand = new Random();
                int value = rand.Next(0, 200);
                account = account + 1;
                Console.WriteLine(account + ".Ваше число:" + value);
                sum = sum + value;
                number = number + 1;

            }
            Console.WriteLine("Среднее арифметическое чисел:" + sum/50);
            Console.ReadLine();
        }
    }
}
