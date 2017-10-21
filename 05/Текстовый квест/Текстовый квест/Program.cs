using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Текстовый_квест
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты - супергерой. Твоя задача - вызволить принцессу/принца из плена Всемирной Сети, куда она/он попала, по неосторожности ткнув в рекламный баннер. В самом начале ты только-только получил известие о неприятности, и стоишь перед выбором:");
            Console.WriteLine("1.Поиграть в Доту");
            Console.WriteLine("2.Узнать, на каком сайте она застряла");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
            }
            else if (answer == 2)
            {
                Console.WriteLine("Рассказывается, что принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob");
                Console.WriteLine("Варианты поведения:");
                Console.WriteLine("1.Послушаться совета в адресе сайта и поиграть в Доту");
                Console.WriteLine("2.Перейти на сайт");
                Console.WriteLine("3.Обновить антивирус, а потом перейти на сайт");
                int answer1 = int.Parse(Console.ReadLine());
                if (answer1 == 1)
                {
                    Console.WriteLine("конец игры, проигрыш - другой хакер спас принцессу");
                }
                else if (answer1 == 2)
                {
                    Console.WriteLine("конец игры, проигрыш - игрок заразился тем же вирусом, что и принцесса, застрял на том же сайте со сломанным компьютером");
                }
                else if(answer1 == 3)
                {
                    Console.WriteLine("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2?");
                    Console.WriteLine("Варианты поведения:");
                    Console.WriteLine("1.А, ну ее, математика для нубов! Пойду в Доту поиграю!");
                    Console.WriteLine("2.Проверить исходный код Капча-Монстра");
                    Console.WriteLine("3.6");
                    int answer3 = int.Parse(Console.ReadLine());
                    if(answer3 == 1)
                    {
                        Console.WriteLine("конец игры, проигрыш - другой хакер спас принцессу");
                    }
                    else if(answer3 == 3)
                    {
                        Console.WriteLine("конец игры, проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2");
                    }
                    else if(answer3 == 2)
                    {
                        Console.WriteLine("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");
                        Console.WriteLine("Варианты поведения:");
                        Console.WriteLine("1.Круто, пойду попробую так в своей программе!");
                        Console.WriteLine("2.Ответить монстру: 6");
                        Console.WriteLine("3.Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра");
                        int answer4 = int.Parse(Console.ReadLine());
                        if(answer4 == 1)
                        {
                            Console.WriteLine("конец игры, проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо");
                        }
                        else if(answer4 == 2)
                        {
                            Console.WriteLine("конец игры, проигрыш - зря, что ли, подвох находил???");
                        }
                        else if(answer4 == 3)
                        {
                            Console.WriteLine("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2 ) * 2?");
                            Console.WriteLine("Варианты поведения:");
                            Console.WriteLine("1.8");
                            Console.WriteLine("2.Герою лень считать, и он идет в Доту");
                            int answer5 = int.Parse(Console.ReadLine());
                            if(answer5 == 2)
                            {
                                Console.WriteLine("конец игры, проигрыш - другой хакер спас принцессу");
                            }
                            else if(answer5 == 1)
                            {
                                Console.WriteLine("Капча-Монстр обиженно сопит \"Как ты догадался? Я же спрятал скобки!\", отступает и позволяет обновить антивирус. ");
                                Console.WriteLine("Теперь герой защищен, и может перейти на сайт!");
                                Console.WriteLine("Едва он делает это, как получает сообщение антивируса:Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:\antivirus\\cure.exe.");
                                Console.WriteLine("Варианты действий:");
                                Console.WriteLine("1.Отправить лекарство принцессе по почте и пойти в Доту");
                                Console.WriteLine("2.Записать лекарство на флешку и пойти к принцессе домой");
                                int answer6 = int.Parse(Console.ReadLine());
                                if(answer6 == 1)
                                {
                                    Console.WriteLine("конец игры, проигрыш - у нее сломался компьютер, она не может получить твой файл! принцессу спасает другой хакер");
                                }
                                else if(answer6 == 2)
                                {
                                    Console.WriteLine("ПОБЕДА!!!");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

