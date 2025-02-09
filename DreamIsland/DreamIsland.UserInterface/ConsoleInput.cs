using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamIsland.Logic;

namespace DreamIsland.UserInterface
{
    public class ConsoleInput
    {
        public static string ReadName()
        {
            while (true)
            {
                Console.Write("Введите ваше имя: ");
                string name = Console.ReadLine();
                if (Verification.IsCorrectName(name))
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, повторите попытку");
                }
            }
        }
        public static int ReadAge()
        {
            int age = 0;
            while (true)
            {
                Console.Write("Введите свой возраст: ");
                string input = Console.ReadLine();
                if ((int.TryParse(input, out age) && Verification.IsCorrectAge(age)))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, повторите попытку");
                }
            }
        }
        public static int ReadAction()
        {
            Console.WriteLine("\nВыберите действие: \n" +
                              "1. Информация об аттракционах \n" +
                              "2. Просмотр корзины\n" +
                              "3. Добавить аттракцион в корзину\n" +
                              "4. Удалить аттракцион из корзины\n" +
                              "5. Подтвердить заказ\n" +
                              "6. Выход");

            Console.Write("Ввод: ");
            var key = Console.ReadKey().Key;
            while (true)
            {
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        return 1;
                    case ConsoleKey.D2:
                        Console.Clear();
                        return 2;
                    case ConsoleKey.D3:
                        Console.Clear();
                        return 3;
                    case ConsoleKey.D4:
                        Console.Clear();
                        return 4;
                    case ConsoleKey.D5:
                        Console.Clear();
                        return 5;
                    case ConsoleKey.D6:
                        Console.Clear();
                        return 6;
                    default:
                        {
                            Console.WriteLine("Некорректный ввод, повторите попытку");
                            break;
                        }
                }
                key = Console.ReadKey().Key;
            }
        }
        public static int ReadTicketType()
        {
            Console.Write("Выберите тип билета: ");
            var key = Console.ReadKey().Key;
            while (true)
            {
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        return 1;
                    case ConsoleKey.D2:
                        Console.Clear();
                        return 2;
                    case ConsoleKey.D3:
                        Console.Clear();
                        return 3;
                    case ConsoleKey.D4:
                        Console.Clear();
                        return 4;
                    default:
                        {
                            Console.WriteLine("\n Некорректный ввод, повторите попытку");
                            break;
                        }
                }
                key = Console.ReadKey().Key;
            }
        }
        public static bool ReadYesOrNo()
        {
            Console.WriteLine("1. Да \n" +
                              "2. Нет");
            var key = Console.ReadKey().Key;
            while (true)
            {
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        return true;
                    case ConsoleKey.D2:
                        Console.Clear();
                        return false;
                    default:
                        {
                            Console.WriteLine("\n Некорректный ввод, повторите попытку");
                            break;
                        }
                }
                key = Console.ReadKey().Key;
            }
        }
        public static bool ReadRepeatTheOperationOrNot()
        {
            Console.WriteLine();
            Console.WriteLine("Повторить операцию?");
            return ReadYesOrNo();
        }
        public static bool ReadClaimOrder()
        {
            Console.WriteLine("Подвердить заказ?");
            return ReadYesOrNo();
        }
        public static int ReadChoisedAttractionInAvailableAtr(List<Attraction> attractions)
        {
            int number = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if ((int.TryParse(input, out number) && (number > 0 && number <= attractions.Count())))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, повторите попытку");
                }
            }
        }
    }
}
