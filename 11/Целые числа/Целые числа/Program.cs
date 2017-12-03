using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Целые_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int account = 0;
            int c = 0;
            int n = 7;
            Random rand = new Random();
            int a = 15;
            int b = n * a;
            if (b > 100)
            {
                while (c < 14)
                {
                    account = account + 1;
                    Console.WriteLine(account + ".Ваше число:" + b);
                    a = a + 1;
                    b = n * a;
                    c = c + 1;
                }
            }
            Console.ReadLine();
        }
    }
}
