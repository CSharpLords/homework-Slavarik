using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MMORPG
{
    class Program
    {
        static double HEROhealth = 100;
        static double HEROattack = 30;
        static double ENEMYhealth = 250;
        static double ENEMYattack = 75;
        static string name = "";
        static bool armor;
        static bool sword;
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите пройти несколько локаций в игре Dark SULLS 1337? Да - Нет");
            string answer = Console.ReadLine();
            if (answer == "Да".ToLower())
            {;
                Console.WriteLine("Полетели)");
                Thread.Sleep(100);
                Console.WriteLine("Заходим в игру...");
                Thread.Sleep(200);
                Console.WriteLine("Ещё пару секунд...");
                Console.WriteLine("Добро пожаловать в игру DARK SULLS 1337! Введите ваше имя:");
                name = Console.ReadLine();
                Field();
            }
            else
            {
                Console.WriteLine("Ок...Я обижен ;(");
                Environment.Exit(0); 
            }
            Console.ReadLine();
        }
        static void Forest() {
            Console.WriteLine();
            Console.WriteLine("На вас напали разбойники!!!");
            Console.WriteLine("Они вам сняли 20 хп");
            HEROhealth = HEROhealth - 20;
            Console.WriteLine("1-Отправиться на поле. 2-В бой!");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Field();
            }
            else if (a == 2)
            {
                Fight();
            }
            Console.ReadLine();
        }
        static void Field()
        {
            Console.WriteLine("Вы начинаете в локации Зеленые поля. Что первым хотите сделать? Здесь доступны лишь 2 действия: 1. Перейти в Лес и 2.Осмотреть поле.");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Forest();
            }
            if (answer == 2)
            {
                Random rand = new Random();
                int item = rand.Next(0, 2);
                if (item == 0)
                {
                    Console.WriteLine("Вам выпал меч. Поздравляю!");
                    HEROattack = HEROattack + 100;
                    sword = true;
                    Console.WriteLine("Теперь отправляйтесь в лес.");
                    Forest();
                }
                if (item == 1)
                {
                    Console.WriteLine("Вам выпала броня. Поздавляю!");
                    HEROhealth = HEROhealth + 200;
                    armor = true;
                    Console.WriteLine("Теперь отправляйтесь в лес.");
                    Field();
                }
            }
        }
        static void Fight() {
            while (true)
            {
                ENEMYattack = GetReducedAttack(ENEMYhealth, 100, 50);
                Console.WriteLine("Ваше здоровье - " + (HEROhealth - ENEMYattack) + ".Здоровье разбойника - " + (ENEMYhealth - HEROattack) + ".");
                HEROhealth = HEROhealth - ENEMYattack;
                ENEMYhealth = ENEMYhealth - HEROattack;
                if (HEROhealth <= 10 && HEROhealth > 0)
                {
                    Console.WriteLine("У вас осталось мало хп! Что будите делать? 1 - Бежать. 2 - Бъёмся! ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        Random rand = new Random();
                        int chance = rand.Next(0, 100);
                        if (sword == true || armor == true)
                        {
                            Console.WriteLine("Шанс на побега 40%");
                            if (chance <= 40)
                            {
                                Console.WriteLine("Вы сбежали!");
                            }
                            else
                            {
                                Console.WriteLine("Вы проиграли!");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Шанс на побега 90%");
                            if (chance <= 90)
                            {
                                Console.WriteLine("Вы сбежали!");
                                Console.WriteLine("Я отправлю вас на поле,чтобы вы поискали вещей)");
                                Field();
                            }
                            else
                            {
                                Console.WriteLine("Вы проиграли!");
                                Environment.Exit(0);
                            }
                        }
                    }
                    if (answer == 2)
                    {
                        Console.WriteLine("Ваши атрибуты повысились! Вам помог чей-то голос в голове!");
                        Console.WriteLine("Вы убили разбойников!");
                        Console.WriteLine("ЭТО GG!!! Вы победили!)");
                    }
                }
                if (HEROhealth <= 0) {
                    Console.WriteLine("Вы проиграли");
                    Environment.Exit(0);
                }
                Console.ReadLine();
            }
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double x = maxHealth / health;
            double attack = maxAttack / x;
            return attack;
        }
    }
}
