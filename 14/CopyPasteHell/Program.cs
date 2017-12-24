using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteHell {
	class Program {
		static void Main(string[] args) {
			float[] numbers = { 765, 341, 1, -3, 0, 13, -200, 23, 44 };
            for(int number = 0;number < 9;number = number + 1)
            {
                numbers[number] = numbers[number] / 5;
            }
			
			Console.ReadLine();
		}
	}
}
