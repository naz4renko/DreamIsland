using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Park
    {
        public List<Zone> zones;
        public List<Attraction> simpleAttractions;
        public string[] ticketsTypes;
        public List<Zone> Zones
        {
            get { return zones; }
        }
        public string[] TicketTypes
        {
            get { return ticketsTypes; }
        }
        public Park(List<Zone> dbZones, string[] dbTickets, List<Attraction> dbAllSimpleAtr)
        {
            zones = dbZones;
            ticketsTypes = dbTickets;
            simpleAttractions = dbAllSimpleAtr;
        }
        public Client CreateClient(string name, int age)
        {
            return new Client(name, age);
        }
        public List<Attraction> GetAvailableAttractions(int age)
        {
            List<Attraction> availableAttractions = new List<Attraction>();

            foreach (var attraction in simpleAttractions)
            {
                if ((age >= attraction.Age && age < 18) || (age >= 18 && attraction.Age + 3 > 18))
                {
                    availableAttractions.Add(attraction);
                }
            }
            return availableAttractions;
        }
        public Ticket ChooseAttractionFromList(List<Attraction> attractions, int userInput)
        {
            Console.WriteLine($"Вы выбрали: '{attractions[userInput - 1].Name}'");
            Ticket simpleTicket = new Ticket(attractions[userInput - 1].Name, attractions[userInput - 1].Price);
            return simpleTicket;
        }
    }
}
