using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рост
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] growth = new int[5];
            Random rand = new Random();

            Console.WriteLine("генерируем рост ребят");
            for (int i = 0; i < growth.Length; i++)
            {
                growth[i] = rand.Next(163, 191);
            }
            for (int i = 0; i < growth.Length; i++)
            {
                Console.WriteLine(growth[i]);
            }

            Console.ReadLine();
        }
    }
}
