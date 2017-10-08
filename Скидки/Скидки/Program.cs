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
            Console.WriteLine("Input cash");
            int cash = int.Parse(Console.ReadLine());
            int price = 50;
            int age = 90;
            int discount = 10;
            if (age < 9)
            {
                price = price - discount;
            }

            Console.WriteLine("Your cash: " + (cash - price));
            Console.ReadLine();
        }
    }
}
