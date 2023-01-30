using System;
using System.Collections.Generic;
using System.Text;

namespace _26._01._Lesson_task
{
    internal class Phone:Product
    {
        public Phone(string name, double price):base(name, price)
        {

        }


        public int Camera;


        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}- Price: {Price}-Camera:{Camera}");
        }

    }
}
