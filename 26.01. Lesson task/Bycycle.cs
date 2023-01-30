using System;
using System.Collections.Generic;
using System.Text;

namespace _26._01._Lesson_task
{
    internal class Bycycle
    {
        public string Brand;
        public string Model;
        public double Millage;


        public void Drive(double km)
        {
            Millage += km;
        }

    }
}
