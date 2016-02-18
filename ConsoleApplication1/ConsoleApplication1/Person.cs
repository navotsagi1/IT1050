using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public string Firstname;
        public string Middleinitial;
        public string Lastname;
        public int Age;
        public int HeightFeet;
        public int HeightInches;
        public bool IsCitizen;

        public string NoInitial() 
        {
        if (Middleinitial == "none") 
        {
                return Middleinitial = null;
        }
            else
             {
                return Middleinitial;
             }
        }
        
        public string fullname() 
        {
            return Firstname + " " + NoInitial() + " " + Lastname;
        }

        public bool QIsCitizen(string x)
        {
            if(x == "yes") 
            {
                return IsCitizen = true;
            }
            else 
            {
                return IsCitizen = false;
            }
        }

        public double InchtoCM()
        {
            return 30.48 * HeightFeet + 2.54 * HeightInches;
        }

        public string CanVote()
        {
            if ((IsCitizen == true) && (Age >= 18))
            {
               return (fullname() + " can vote");
            }
            else
            {
                return (fullname() + " cannot vote");
            }
        }
    }
}
