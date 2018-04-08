using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolLine {
	class Program {
		static void Main(string[] args) {
			PrintSymbols("*", 10);
			PrintSymbols("+", 5);

			Console.ReadLine();
		}
        static void PrintSymbols(string Picture , int amount) {
            string Picture2 = Picture;
            for (int n = 1; n < amount; n++)
            {
                Picture = Picture + Picture2;

            }
            Console.WriteLine(Picture);
        }
	}
}
