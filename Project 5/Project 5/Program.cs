using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Course Course1 = new Course();
            Course1.AskForName();
            Course1.AskForNumber();
            Course1.AskForStudents();
            
            System.Console.WriteLine("Course name: " + Course1.GetName());
            System.Console.WriteLine("Course CRN number: " + Course1.GetNumber());
            System.Console.WriteLine("Students list: ");
            Course1.PrintNameList();

            System.Console.WriteLine("Is the information above correct?");
            string Answer = System.Console.ReadLine();

            while ((Answer == "No") || (Answer == "no")) 
            {

                List<Student>EmptyList = new List<Student>();
                Course1.ListOfStudents = EmptyList;
                                
                Course1.AskForName();
                Course1.AskForNumber();
                Course1.AskForStudents();

                System.Console.WriteLine("Course name: " + Course1.GetName());
                System.Console.WriteLine("Course CRN number: " + Course1.GetNumber());
                System.Console.WriteLine("Students list: ");
                Course1.PrintNameList();

                System.Console.WriteLine("Is the information above correct?");
                Answer = System.Console.ReadLine();
            }

            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
