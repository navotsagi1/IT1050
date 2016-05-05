using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Customer
    {
        private string Name;
        private string AgeStatus;
        private double Money;
        List<string> WhatIBought = new List<string>();

        public Customer(string name, string agestatus, double money)
        {
            Name = name;
            AgeStatus = agestatus;
            Money = money;
        }

        public void FreeStuff(string Item, double DiscountPrice)
        {
            string A = System.Console.ReadLine();
            if ((A == "Yes") || (A == "yes"))
            {
                Money -= DiscountPrice;
                WhatIBought.Add(Item);
            }
        }


        public void BuyFood(Concessions Item, int Amount)
        {

            Money -= Item.GetPrice() * Amount;
            WhatIBought.Add(Item.GetName());

            if ((Item.GetName() == "Candy") && (Amount == 3))
            {
                System.Console.WriteLine("Would You like an aditional free candy?");
                FreeStuff("Candy", 0);
            }

        }


        public void BuyTicket(Ticket ticket, int Amount)
        {
            Money -= ticket.GetPrice() * Amount;
            WhatIBought.Add(ticket.GetAge() + " " + ticket.GetTime() + " ticket.");

            if ((Amount == 3) && (ticket.GetTime() == "Evening"))
            {
                System.Console.WriteLine("Would you like a free bug of popcorn?");
                FreeStuff("Popcorn", 0);
            }

            if ((WhatIBought.Contains("Popcorn")) && (WhatIBought.Contains("Large Soda")))
            {
                System.Console.WriteLine("Would You like an aditional movie ticket with 2$ discount?");
                FreeStuff(ticket.GetName(), (ticket.GetPrice() - 2));
            }

        }
    }
}
