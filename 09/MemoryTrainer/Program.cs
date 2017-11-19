using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryTrainer {
	class Program {
		static void Main(string[] args) {
			GuessNumber();
		}

		static void GuessNumber() {
			Random rand = new Random();

            int score = 100;
            int time = 2000;
            int replay = 0;
			while (true) {
                int number = rand.Next(score);


				Console.WriteLine("Запомните число: " + number);
				Thread.Sleep(time);
				Console.Clear();

				Console.WriteLine("Введите запомненное число");
				int guess = int.Parse(Console.ReadLine());
				Console.WriteLine();

				if (guess == number) {
					Console.WriteLine("Вы угадали!");
                    score = score + 200;
                    number = rand.Next(score);
                    replay = replay + 1;
                    if (replay >= 3)
                    {
                        time = time - 100;
                        Thread.Sleep(time);
                    }

				}
				else {
					Console.WriteLine("Вы ошиблись ='(");                    
                    score = score - 100;
                    number = rand.Next(score);
				}
				Thread.Sleep(1000);
				Console.Clear();
			}
		}
	}
}
