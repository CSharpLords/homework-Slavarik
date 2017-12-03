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
            int Value = 0;
            int n = 0;
            int number = 0;
            int number1 = 0;
            Random rand = new Random();
            while(n < 1)
            {
                number = rand.Next(100, 200);
                int Ost1 = number % 7;                           //что-то новое...
                if (Ost1 == 0)
                {
                    Thread.Sleep(250);
                    account = account + 1;
                    Console.WriteLine(account + ".Число:" + number);
                    Value = Value + 1;
                    n = n + 1;
                }
            }

            while (Value < 14)
            {
                number1 = rand.Next(100, 200);
                int Ost1 = number1 % 7;                           
                if(Ost1 == 0)
                {
                    if(number != number1)
                    {
                        Thread.Sleep(250);
                        account = account + 1;
                        Console.WriteLine(account + ".Число:" + number1);
                        Value = Value + 1;
                    }                                      
                }
            }
            Console.ReadLine();    
        }
    }
}
