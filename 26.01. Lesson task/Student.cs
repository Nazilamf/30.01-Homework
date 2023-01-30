using System;
using System.Collections.Generic;
using System.Text;

namespace _26._01._Lesson_task
{
    internal class Student:Human
    {
        public Student(string name, string Group):base(name)
        {
            this.Group = Group;
        }




        public string Group;
    }
}
