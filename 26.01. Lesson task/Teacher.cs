using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _26._01._Lesson_task
{
    internal class Teacher:Employee
    {
        public Teacher(string name, string position, string profession):base(name,position)
        {
            this.Profession = profession;   
        }




        public string Profession;

    }


}
