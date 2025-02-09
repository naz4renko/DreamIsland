using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Check
    {
        private List<Ticket> tickets;
        private int totalPrice;
        private string clientName;
        private int clientAge;
        public List<Ticket> Tickets { get { return tickets; } }
        public int TotalPrice { get { return totalPrice; } }
        public string ClientName { get { return clientName; } }
        public int ClientAge { get { return clientAge; } }
        public Check(Order order)
        {
            tickets = order.Tickets;
            totalPrice = order.TotalPrice;
            clientName = order.ClientName;
            clientAge = order.ClientAge;
        }
    }
}
