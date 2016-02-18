using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            System.Console.WriteLine("Enter first name here");
            person.Firstname = System.Console.ReadLine();
            System.Console.WriteLine("Enter middle initial here,(if none, enter none)");
            person.Middleinitial = System.Console.ReadLine();
            System.Console.WriteLine("Enter last name here");
            person.Lastname = System.Console.ReadLine();

            System.Console.WriteLine("Enter Age here");
            person.Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Are you a U.S. citizen?,(yes or no).");
            person.QIsCitizen(System.Console.ReadLine());


            System.Console.WriteLine("Enter Height, (feet), in here.");
            person.HeightFeet = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter height, (inches), in here.");
            person.HeightInches = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine("Name: " + person.fullname());
            System.Console.WriteLine("Height(cm): " + person.InchtoCM());
            System.Console.WriteLine("Voting Status: " + person.CanVote());


            System.Console.WriteLine("Press any key to continue......");
            Console.ReadKey();
        }
    }
}
