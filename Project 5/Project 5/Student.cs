using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Student
    {
        private string Name;
        private int SNumber;
        public string GetName() { return Name; }
        public int GetNumber() { return SNumber; }


        public void SetName (string name)
        {
            Name = name;
        }

        public void SetNumber (int number)
        {
            SNumber = number;
        }

    }
}
