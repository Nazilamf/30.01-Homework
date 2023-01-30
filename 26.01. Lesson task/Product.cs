using System;
using System.Collections.Generic;
using System.Text;

namespace _26._01._Lesson_task
{
    internal class Product
    {

        public Product(string name,double price)
        {
            this.Name = name;
            this.Price= price;
        }


        public string Name;
        public double Price;


        public virtual void ShowInfo()

        {
           Console.WriteLine($"Name: {"name"} - Price:{"price"}") ;
        }


    }
}
