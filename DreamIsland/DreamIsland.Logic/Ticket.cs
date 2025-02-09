using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Ticket
    {
        public string Type { get; }
        public int Price { get; }
        public Ticket(string type, int price)
        {
            Type = type;
            Price = price;
        }
    }
}
