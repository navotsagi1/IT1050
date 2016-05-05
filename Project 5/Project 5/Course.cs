using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Course
    {
        private string Name;
        private int CRNNumber;
        public string GetName() { return Name; }
        public int GetNumber() { return CRNNumber; }
        public List<Student> ListOfStudents = new List<Student>();



        public void AskForName()
        {
            System.Console.WriteLine("What is the name of your course?");
            Name = System.Console.ReadLine();  
        }

        public void AskForNumber()
        {
            System.Console.WriteLine("What is the CRN number of your course?");
            CRNNumber = int.Parse(System.Console.ReadLine());
        }

 
       public void AskForStudents()
       {
            System.Console.WriteLine("How many students are in your course?");
            int Amount = int.Parse(System.Console.ReadLine());
            Student[] ArrayOfStudents = new Student[Amount];
            for (int i = 0; i <= ArrayOfStudents.Length; i++)
            {
                ArrayOfStudents[i] = new Student();
                ArrayOfStudents[i].SetName("Jimmy");
                ArrayOfStudents[i].SetNumber(i);
            }

            ListOfStudents.AddRange(ArrayOfStudents);
       }
        
       public void PrintNameList()
       {
            foreach (Student student in ListOfStudents) 
            {
                System.Console.WriteLine(student.GetName() + " " + student.GetNumber());
            } 
       }
    }
}
