using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator Elevator1 = new Elevator(2, 400);
            Passenger Passenger1 = new Passenger("A1", 180);
            Passenger passenger2 = new Passenger("A2", 220);

            Elevator1.AddOccupant(Passenger1, 0);
            Elevator1.AddOccupant(passenger2, 1);

            bool Elevator1IsOverMaxCapacity = Elevator1.IsOverMaxCapacity();
            

            Elevator Elevator2 = new Elevator(3, 600);
            Passenger Passenger3 = new Passenger("A1", 200);
            Passenger passenger4 = new Passenger("A2", 200);
            Passenger passenger5 = new Passenger("A3", 201);
           
            bool Elevator2IsOverMaxCapacity = Elevator2.IsOverMaxCapacity();
            
            System.Console.ReadKey();
        }
    }
}
