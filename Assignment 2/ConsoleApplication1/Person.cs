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
        public string Lastname;
        public int Age;
        public string Spouse;
        public int SpouseAge;
        public static double SumOfAllAges;

       public Person()
       {
            System.Console.WriteLine("New person information: " );

            System.Console.WriteLine("Enter Your First Name Here: ");
            Firstname = System.Console.ReadLine();
            System.Console.WriteLine("Enter Your Last Name Here: ");
            Lastname = System.Console.ReadLine();

            System.Console.WriteLine("Enter Your Age Here: ");
            Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter your spouse's name here, if you do not have a spouse enter 'none'.");
            Spouse = System.Console.ReadLine();
            
            if ((NoSpouse() == null) == false)
            {
                System.Console.WriteLine("Enter spouse's age here: ");
                SpouseAge = int.Parse(System.Console.ReadLine());
            }

            SumOfAllAges += this.Age + this.SpouseAge;
       }

          public string GetFullName()
        {
            return Firstname+" " + Lastname;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + Age);
            if ((Spouse == "none") == false)
             {
                System.Console.WriteLine(Spouse + SpouseAge);
             }
        }
        
        public string NoSpouse()
        {
            if (Spouse == "none")
            {
                return Spouse = null;
            }
            else
            {
                return Spouse;
            }
        }

        public void GetInfo()
        {
            System.Console.WriteLine("Person's Info");
            System.Console.WriteLine("Name: " + GetFullName());
            System.Console.WriteLine("Spouse's name: " + NoSpouse());
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            System.Console.WriteLine("==========================================================================");
        }

    }
}
