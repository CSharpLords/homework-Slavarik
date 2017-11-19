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
            Console.WriteLine("Чтобы закрыть меня,реши задачку:");
            while (true)
            {
                Random rand = new Random();
                int a = rand.Next(10);
                int b = rand.Next(10);
                int c = rand.Next(10);
                Console.WriteLine("Сколько будет " + a + "+" + b + "+" + c);
                int answer = int.Parse(Console.ReadLine());
                if (answer == (a + b + c))
                {
                    Console.WriteLine("Ты просто лучший");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуй ещё раз");
                }
            }
        }
    }
}
