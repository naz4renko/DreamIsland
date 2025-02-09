using DreamIsland.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.UserInterface
{
    public class MainController
    {
        public MainController()
        {
        }
        public Client CreateClient(Park myPark)
        {
            string name = ConsoleInput.ReadName();
            int age = ConsoleInput.ReadAge();
            Client client = myPark.CreateClient(name, age);
            return client;
        }
        public void MainProcess(Park myPark, Client client)
        {
            Cart cart = client.Cart;
            bool main = true;
            while (main)
            {
                int action = ConsoleInput.ReadAction();
                switch (action)
                {
                    case 1:
                        {
                            //Просмотр каталога
                            ConsolePrint.ViewCatalog(myPark);
                            break;
                        }
                    case 2:
                        {
                            //Просмотр корзины
                            ConsolePrint.ViewClientCart(cart);
                            break;
                        }
                    case 3:
                        {
                            //Добавление билета
                            bool process = true;
                            while (process)
                            {
                                ConsolePrint.ViewTicketsInfo(myPark);
                                int ticketType = ConsoleInput.ReadTicketType();
                                if (ticketType != 2)
                                {
                                    Ticket ticket = null;
                                    ticket = cart.TakeGeneralTicket(ticketType);
                                    cart.AddTicket(ticket);
                                }
                                else
                                {
                                    Ticket ticket = null;
                                    List<Attraction> attractions = myPark.GetAvailableAttractions(client.Age);
                                    ConsolePrint.ViewAvailableAttraction(attractions);
                                    Console.WriteLine("123Введите номер аттракциона: ");
                                    int choise = ConsoleInput.ReadChoisedAttractionInAvailableAtr(attractions);
                                    ticket = myPark.ChooseAttractionFromList(attractions, choise);
                                    cart.AddTicket(ticket);
                                }
                                process = ConsoleInput.ReadRepeatTheOperationOrNot();
                            }
                            break;
                        }
                    case 4:
                        {
                            //Удаление билета
                            bool process = true;
                            while (process)
                            {
                                Console.WriteLine("Выберите цифру с билетом, который хотите удалить\n" +
                                                  "0. Назад");
                                ConsolePrint.ViewTicketListForRemoved(cart.GetTickets());
                                int number = int.Parse(Console.ReadLine());
                                cart.RemoveTicket(number);
                                process = ConsoleInput.ReadRepeatTheOperationOrNot();
                            }
                            break;
                        }
                    case 5:
                        {
                            //Подтверждение заказа
                            if (ConsoleInput.ReadClaimOrder())
                            {
                                Order order = new Order(client);
                                Check check = new Check(order);
                                ConsolePrint.ViewFinalCheck(check);
                                main = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Некорректный ввод, повторите попытку!");
                            break;
                        }
                }
            }
        }
    }
}
