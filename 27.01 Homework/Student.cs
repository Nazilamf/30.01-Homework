using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _27._01_Homework
{
    internal class Student:Human
    {
        public string Group;


        public Student(string fullname, string group):base(fullname)
        {
            this.Group = group;    
        }


        public bool IsCorectGroup(string group)
        {
            for (int i = 0; i < group.Length; i++)
            {
                if (char.IsUpper(group[0]))
                {
                    return true;
                }
            }
            for (int i = 1; i < group.Length; i++)
            {
                if (char.IsDigit(group[i]))
                {
                    return true;
                }

            }

            return false;
        }


        public bool ISCorrectFullName(string fullname)
        {

            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsLetter(fullname[i]))
                {
                    return true;
                }
            }

            return false;

        }



        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Group: {Group}");
        }


    }




}
