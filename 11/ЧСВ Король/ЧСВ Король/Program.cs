using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧСВ_Король
{
    class Program
    {
        static void Main(string[] args)
        {
            int Boyarine = 0;
            int VisokieHolopi = 0;
            while(Boyarine < 20)
            {
                Console.WriteLine("Введите рост человечка)");
                int Rost = int.Parse(Console.ReadLine());
                if(Rost <= 160)
                {
                    Console.WriteLine("Хороший карлик)");
                    Console.WriteLine();
                    Boyarine = Boyarine + 1;
                }
                else
                {
                    Console.WriteLine("Высокий ...");
                    Console.WriteLine();
                    Boyarine = Boyarine + 1;
                    VisokieHolopi = VisokieHolopi + 1;
                }
            }
            Console.WriteLine("Надо нам укаротить:" + VisokieHolopi);
            Console.ReadLine();
        }
    }
}
