using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Concessions
    {
        private string Name;
        private double Price;
        public double GetPrice() { return Price; }
        public string GetName() { return Name; }

        public Concessions (string name, double price)
        {
            Price = price;
            Name = name;
        }
        
    }
}
