using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Client
    {
        string name;
        int age;
        Cart cart;
        public int Age
        {
            get { return age; }
        }
        public string Name
        {
            get { return name; }
        }
        public Cart Cart
        {
            get { return cart; }
        }

        public Client(string name, int age)
        {
            this.name = name;
            this.age = age;
            cart = new Cart();
        }
    }
}
