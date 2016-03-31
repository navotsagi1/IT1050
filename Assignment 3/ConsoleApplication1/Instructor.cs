using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor (string name, string coursename)
        {
            Name = name;
            CourseName = coursename;
        }

        public void SetGrade(Student student, int grade)
        {
            student.GetGrade(grade);
            System.Console.WriteLine(Name + " has set " + student.GetName() + "'s grade to " + grade);
            Devider.devider();
        }

        public void TeacherInfo ()
        {
            System.Console.WriteLine("My name is: " + Name);
            System.Console.WriteLine("I'm teaching " + CourseName);
        }
       
    }
}
