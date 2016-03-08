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
            Person p1 = new Person();
            Person p2 = new Person();

            p1.GetInfo();
            p2.GetInfo();

            System.Console.WriteLine("The average of ages is: " + Person.SumOfAllAges/4);
            System.Console.WriteLine();
            System.Console.ReadKey();
        }
    }
}
