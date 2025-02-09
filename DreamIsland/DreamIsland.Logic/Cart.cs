using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Cart
    {
        private List<Ticket> tickets;
        private int totalPrice;
        public Cart()
        {
            tickets = new List<Ticket>();
        }
        public Ticket TakeGeneralTicket(int ticketType)
        {
            bool buying = true;
            Ticket ticket = null;
            while(buying)
            {
                switch (ticketType)
                {
                    case 1:
                        ticket = new Ticket("Всё включено", 2500);
                        buying = false;
                        break;
                    case 3:
                        ticket = new Ticket("Студенческий", 1500);
                        buying = false;
                        break;
                    case 4:
                        ticket = new Ticket("Семейный", 5500);
                        buying = false;
                        break;
                    default:
                        throw new UserWrongException();
                }
            }
            return ticket;
        }
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void RemoveTicket(int number)
        {
            bool validInput = false;
            while (!validInput)
            {
                if (number < 0 || number > tickets.Count())
                {
                    throw new UserWrongException();
                }
                else if (number == 0)
                {
                    break;
                }
                else
                {
                    tickets.Remove(tickets[number - 1]);
                    validInput = true;
                }
            }
        }
        public List<Ticket> GetTickets()
        {
            return tickets;
        }
        public int GetTotalPrice()
        {
            totalPrice = 0;
            foreach (Ticket ticket in tickets)
            {
                totalPrice += ticket.Price;
            }
            return totalPrice;
        }
    }
}
