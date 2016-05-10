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
            Passenger Passenger2 = new Passenger("A2", 220);

            Elevator1.AddOccupant(Passenger1, 0);
            Elevator1.AddOccupant(Passenger2, 1);

            bool Elevator1IsOverMaxCapacity = Elevator1.IsOverMaxCapacity();
            

            Elevator Elevator2 = new Elevator(3, 600);
            Passenger Passenger3 = new Passenger("A1", 200);
            Passenger Passenger4 = new Passenger("A2", 200);
            Passenger Passenger5 = new Passenger("A3", 201);

            Elevator2.AddOccupant(Passenger3, 0);
            Elevator2.AddOccupant (Passenger4, 1);
            Elevator2.AddOccupant(Passenger5, 2);
            
            bool Elevator2IsOverMaxCapacity = Elevator2.IsOverMaxCapacity();

            System.Console.ReadKey();
        }
    }
}
