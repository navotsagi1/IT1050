using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants = new Passenger []{ };

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

       
         public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = new Passenger(passenger.GetName(), passenger.GetWeight());
        }

        public double GetCurrentWeight ()
        {
            double x = 0;
            foreach (Passenger passenger in Occupants)
            {
                x = x + passenger.GetWeight();
            }
            return x;
        }
     
           public bool IsOverMaxCapacity()
        {
         if (GetCurrentWeight() > MaxWeight)
          {
                return true;
          }
         else
          {
                return false;
          }
        }

    }
}
