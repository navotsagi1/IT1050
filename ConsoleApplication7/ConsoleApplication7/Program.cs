using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
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
            person.IsCitizen = System.Console.ReadLine();

            
            System.Console.WriteLine("Enter Height, (feet), in here.");
            person.Heightfeet = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter height, (inches), in here.");
            person.Heightinches = int.Parse(System.Console.ReadLine());

            
            System.Console.WriteLine("Name: " + person.fullname());
            System.Console.WriteLine("Height(cm): " + person.InchtoCM());

            if ((person.Qiscitizen() == true) && (person.Age >= 18))
            {
                System.Console.WriteLine(Person.Fullname + " is eligible to vote");
            }
            else
            {
                System.Console.WriteLine(Person.Fullname + " cannot vote");
            }

            
            System.Console.WriteLine("Press any key to continue......");
            Console.ReadKey();
        }
    }
}