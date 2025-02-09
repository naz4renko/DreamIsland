using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Order
    {
        private List<Ticket> tickets;
        private int totalPrice;
        private string clientName;
        private int clientAge;

        public List<Ticket> Tickets
        {
            get { return tickets; }
        }
        public int TotalPrice
        {
            get { return totalPrice; }
        }
        public string ClientName
        {
            get { return clientName; }
        }
        public int ClientAge
        {
            get { return clientAge; }
        }
        public Order(Client client)
        {
            Cart cart = client.Cart;
            tickets = cart.GetTickets();
            totalPrice = cart.GetTotalPrice();
            clientName = client.Name;
            clientAge = client.Age;
        }
    }
}
