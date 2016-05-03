using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Ticket
    {
        private string AgeStatus;
        private double Price;
        private string ShowTime;
        public string GetName() { return AgeStatus + " " + ShowTime + " show ticket"; }
        public double GetPrice() { return Price; }
        public string GetAge() { return AgeStatus; }
        public string GetTime() { return ShowTime; }
        
        public Ticket (string agestatus, double price, string showtime)
        {
            AgeStatus = agestatus;
            Price = price;
            ShowTime = showtime;
        }

    }
}
