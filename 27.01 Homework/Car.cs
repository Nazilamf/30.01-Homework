using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _27._01_Homework
{
    internal class Car : Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;


        public Car(string brand, string model, double millage, byte fuelcapacity, int currentfuel) : base(brand, model, millage)
        {

            this.FuelCapacity = fuelcapacity;
            this.CurrentFuel = currentfuel;
        }


        public void AddFuel()
        {

            Console.WriteLine("Benzin miqdari qeyd edin:");
            string fuelstr =Console.ReadLine();
            int fuel = Convert.ToInt32(fuelstr);
            
            int Newcurrentfuel;

            Newcurrentfuel = CurrentFuel + fuel;


            if (Newcurrentfuel <= FuelCapacity)
            {
                Console.WriteLine(Newcurrentfuel);
            }
            else Console.WriteLine("Bak doludur");







        }








    }
}

    







