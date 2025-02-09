using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Attraction
    {
        private string name;
        private int price;
        private int age;
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public int Price
        {
            get { return price; }
        }
        public Attraction(string name, int price, int age)
        {
            this.name = name;
            this.price = price;
            this.age = age;
        }
    }
}
