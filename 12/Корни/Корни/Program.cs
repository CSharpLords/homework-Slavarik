using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Корни
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0.0;

            while(n < 0.9)
            {
                Console.WriteLine("Корень из:" + n + " = " + Math.Sqrt(n));
                n = n + 0.1;
            }
            Console.ReadLine();
        }
    }
}
