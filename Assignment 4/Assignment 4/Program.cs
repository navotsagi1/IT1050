using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Ticket ChildMaitnee = new Ticket("Child", 3.99, "Maitnee");
            Ticket AdultMaitnee = new Ticket("Adult", 5.99, "Maitnee");
            Ticket SeniorMaitnee = new Ticket("Senior", 4.50, "Maitnee");

            Ticket ChildEvning = new Ticket("Child", 6.99, "Evning");
            Ticket AdultEvning = new Ticket("Adult", 10.99, "Evning");
            Ticket SeniorEvning = new Ticket("Senior", 8.50, "Evning");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Concessions SmallSoda = new Concessions("SmallSoda", 3.50);
            Concessions LargeSoda = new Concessions("Large Soda", 5.99);
            Concessions HotDog = new Concessions("Hot Dog", 3.99);
            Concessions Popcorn = new Concessions("Popcorn", 4.50);
            Concessions Candy = new Concessions("Candy", 1.99);


            System.Console.ReadKey();
            
        }
    }
}
