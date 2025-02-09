using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Zone
    {
        public string name;
        public List<Attraction> attractions;

        public Zone()
        {
            attractions = new List<Attraction>();
        }
        public void AddAttraction(Attraction attraction)
        {
            attractions.Add(attraction);
        }
    }
}

