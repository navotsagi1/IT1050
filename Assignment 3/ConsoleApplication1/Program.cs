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
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            Devider.devider();

            John.SetGrade(Jane, 95);
            John.SetGrade(Joe, 85);

            Mike.SetGrade(Melissa, 90);
            Mike.SetGrade(Matt, 92);

            

            Jane.StudentInfo();
            Joe.StudentInfo();
            Melissa.StudentInfo();
            Matt.StudentInfo();

            System.Console.ReadKey();
        }
    }
}
