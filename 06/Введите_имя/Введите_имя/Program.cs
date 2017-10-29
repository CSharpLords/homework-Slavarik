using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Введите_имя
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            int Name = int.Parse(Console.ReadLine());
            SayHello("name");
        }
        static void SayHello(string Pull)
        {
            Console.WriteLine("Здарвстуйте,");
            Console.ReadLine();
        }
    }

}
