using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру: \nКамень, Ножницы, Бумага!\n_________________________\n");
            while (true)
            {
                Console.WriteLine("Выберите: 1 - Камень, \n          2 - Ножницы, \n          3 - Бумага, \n          0 - Выход.\n_________________________\n");
                Console.Write("Я выбираю: ");

                try
                {
                    int viborIgroka = Convert.ToInt32(Console.ReadLine());
                    switch (viborIgroka)
                    {
                        case 1:
                            Console.WriteLine("Вы выбрали Камень!\n\nТеперь выбор компьютера");
                            PlayGame(viborIgroka);
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали Ножницы!\n\nТеперь выбор компьютера");
                            PlayGame(viborIgroka);
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали Бумагу!\n\nТеперь выбор компьютера");
                            PlayGame(viborIgroka);
                            break;
                        case 0:
                            Console.WriteLine("\n_________________________\nСпасибо за игру!\nДо свидания!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\nНеправильный ввод!\nПопробуйте ещё раз.\n\n_________________________");
                            break;
                    };
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nНеправильный ввод!\nПопробуйте ещё раз.\n\n_________________________");
                }
            }
        }

        static void PlayGame(int viborIgroka)
        {
            Random random = new Random();
            int viborCompa = random.Next(1, 4);

            Console.Write("Компьютер выбрал: ");
            switch (viborCompa)
            {
                case 1:
                    Console.WriteLine("Камень!\n_________________________");
                    break;
                case 2:
                    Console.WriteLine("Ножницы!\n_________________________");
                    break;
                case 3:
                    Console.WriteLine("Бумага!\n_________________________");
                    break;
            }
            if (viborIgroka == viborCompa)
            {
                Console.WriteLine("\n\n\nНичья!");
            }
            else if ((viborIgroka == 1 && viborCompa == 2) || (viborIgroka == 2 && viborCompa == 3) || (viborIgroka == 3 && viborCompa == 1))
            {
                Console.WriteLine("\n\n\nВы выиграли!");
            }
            else { Console.WriteLine("\n\n\nВы проиграли!"); }
            Console.WriteLine("\n\n\n_________________________________\n\nНажмите Esc чтобы выйти\nили Enter чтобы сыграть ещё раз\n_________________________________\n");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Спасибо за игру!\nДо свидания!");
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}