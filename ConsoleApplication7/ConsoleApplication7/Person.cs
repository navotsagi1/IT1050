using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Person
    {
        public string Firstname;
        public string Middleinitial;
        public string Lastname;
        //public static string Fullname;
        public int Age;
        public int Heightfeet;
        public int Heightinches;
        public string IsCitizen;
        public bool AIsCitizen;

        public string Initial()
         {
            if (this.Middleinitial == "none") 
            {
                return Middleinitial = null;
            }
            else
            {
                return (this.Middleinitial);
            }
        }    

        public string fullname() 
        {
            return this.Firstname + this.Middleinitial + Lastname;
        }


        public bool Qiscitizen()
        {
            if (IsCitizen == "yes")
            {
                return (AIsCitizen = true);
            }
            else
            {
                return (AIsCitizen = false);
            }
        }


        public double InchtoCM() 
        {
            double HeightCM = 0;
            HeightCM += (30.38 * Heightfeet + 2.54 * Heightinches);
            return HeightCM;
        }

    }
} 
