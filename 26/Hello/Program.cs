using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
	class Program {
        static Random rand = new Random();
		static void Main(string[] args) {
			SayHello("Маша");
			SayHello("Женя");
			SayHello("Петя");

			Console.ReadLine();
		}

		 static void SayHello(string name) {
            int number = rand.Next(0, 3);
            if (number == 0)
            {
                Console.WriteLine("Привет," + name);
            }
            if (number == 1)
            {
                Console.WriteLine("Доброго ранку," + name);
            }
            if (number == 2)
            {
                Console.WriteLine("Hello," + name);
            }
		}
	}
}
