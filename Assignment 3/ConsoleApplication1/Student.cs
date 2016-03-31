using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Instructor;

       
        public Student (string name, Instructor instructor)
        {
            Name = name;
            Grade = 0;
            Instructor = instructor;
        }

        public void StudentInfo()
        {
            System.Console.WriteLine("My name is: " + Name);
            System.Console.WriteLine("Grade: " + Grade);
            System.Console.WriteLine("My teacher's info: ");
            Instructor.TeacherInfo();
            Devider.devider();
        }

        public string GetName()
        {
            return Name;
        }

        public int GetGrade (int x)
    {
            return Grade = x;
    }



    }
}
