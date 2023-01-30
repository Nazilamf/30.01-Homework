using System;
using System.Collections.Generic;
using System.Text;

namespace _26._01._Lesson_task
{
    internal class Employee:Human
    {

        public Employee(string name, string position):base(name)
        {
            this.Position= position;
        }


        public string Position;
        public double Salary;

    }
}
