using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DreamIsland.Logic;

namespace DreamIsland.UserInterface
{
    public class ConsolePrint
    {
        public static void HelloUser()
        {
            Console.WriteLine("\nДобро пожаловать в Парк Аттракционов Dream Island!");
        }
        public static void FilesNotFound()
        {
            Console.WriteLine("\nОшибка в файлами");
        }
        public static void ViewCatalog(Park park)
        {
            Console.WriteLine();
            List<Zone> zones = park.Zones;
            for (int i = 0; i < zones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {zones[i].name}");
            }
            Console.WriteLine("Введите номер зоны (или '0' для выхода):");
            bool exit = false;
            while (!exit)
            {
                bool validInput = false;
                while (!validInput)
                {
                    if (int.TryParse(Console.ReadLine(), out int userInput))
                    {
                        if (userInput >= 1 && userInput <= zones.Count)
                        {
                            Console.WriteLine($"Аттракционы: '{zones[userInput - 1].name}':");
                            foreach (var attraction in zones[userInput - 1].attractions)
                            {
                                Console.WriteLine($"- {attraction.Name}, Цена: {attraction.Price}, Возраст: {attraction.Age}");
                            }
                            Console.WriteLine("0. Назад");
                            validInput = true;
                        }
                        else if (userInput == 0)
                        {
                            validInput = true;
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод, повторите попытку");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод, повторите попытку");
                    }
                }
            }
        }
        public static void ViewTicketsInfo(Park park)
        {
            Console.WriteLine();
            string[] ticketsTypes = park.TicketTypes;
            Console.WriteLine("Выберите билет: ");
            for (int i = 0; i < ticketsTypes.Length; i++)
            {
                Console.WriteLine(ticketsTypes[i]);
            }
        }
        public static void ViewClientCart(Cart cart)
        {
            Console.WriteLine();
            List<Ticket> tickets = cart.GetTickets();
            Console.WriteLine("Ваша корзина:");
            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tickets[i].Type} - Цена: {tickets[i].Price}");
            }
            Console.WriteLine("Итого: " + cart.GetTotalPrice());
        }
        public static void ViewFinalCheck(Check check)
        {
            Console.WriteLine("Чек:");
            Console.WriteLine($"Клиент: {check.ClientName} \nВозраст: {check.ClientAge}\n Билеты:");
            foreach (var item in check.Tickets)
            {
                Console.WriteLine($"Тип: {item.Type}, Стоимость: {item.Price}");
            }
            Console.WriteLine($"Итого: {check.TotalPrice}");
            Console.WriteLine("");
            Console.WriteLine("Спасибо за покупку!");
        }
        public static void ViewAvailableAttraction(List<Attraction> attractions)
        {
            Console.WriteLine("Доступные аттракционы:");
            for (int i = 0; i < attractions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {attractions[i].Name}, Цена: {attractions[i].Price}, Возраст: {attractions[i].Age}");
            }
        }
        public static void ViewTicketListForRemoved(List<Ticket> tickets) 
        {
            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tickets[i].Type} - Цена: {tickets[i].Price}");
            }
        }
    }
}
