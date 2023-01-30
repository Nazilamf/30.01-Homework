using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace _26._01._Lesson_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student st1 = new Student("Leyla", "P241")
            //{
            //    Surname ="Quliyeva",
            //    Age = 22

            //};


            //Employee emp1 = new Employee("Rufet", "electric")
            //{
            //    Surname ="Bayramov",
            //    Age = 36
            //};

            //Teacher tc1 = new Teacher("Sabina", "Teacher", "History")
            //{
            //    Age = 30
            //};



            //Human hm1 = new Human("Maryam")
            //{
            //    Surname = "Valiyeva",
            //    Age = 25

            //};



            ////Bycycle task

            //Console.WriteLine("Velosiped sayi:");
            //string countstr = Console.ReadLine();   
            //int count = Convert.ToInt32(countstr);


            //Bycycle[] bycycles= new Bycycle[count];

            //for (int i = 0; i < bycycles.Length; i++)
            //{
            //    string brand;

            //    do
            //    {
            //        Console.WriteLine("Brand:");
            //        brand = Console.ReadLine();

            //    } while (string.IsNullOrWhiteSpace(brand));


            //    string model;
            //    do
            //    {
            //        Console.WriteLine("Model:");
            //        model = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(model));

            //    Bycycle bc = new Bycycle
            //    {
            //        Brand = brand,
            //        Model = model

            //    };

            //    bycycles[i] = bc;

            //}
            //    Console.WriteLine("1. Butun velosipedlere bax");
            //    Console.WriteLine("2. Velosipedler arasinda model adina gore axtaris et");
            //    Console.WriteLine("Emeliyyat secin:");

            //    string opr = Console.ReadLine();    

            //    if(opr == "1")
            //    {
            //        foreach (var item in bycycles)
            //        {
            //            Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Millage: {item.Millage}");
            //        }
            //    }
            //    else if(opr =="2")
            //    {
            //        Console.WriteLine("Modeli daxil edin:");
            //        string wantedModel = Console.ReadLine();

            //        foreach (var item in bycycles)
            //        {
            //            if (item.Model.Contains(wantedModel))
            //            {
            //                Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Millage: {item.Millage}");
            //            }

            //        }
            //    }

            //Product task


            Product pr1 = new Product("Airpods", 350);

            Notebook nt1 = new Notebook("HP Pavilion", 2500) { RAM = 15, Storage =512 };

            Phone ph1 = new Phone("iphone14", 2000) { Camera= 15 };
            Phone ph2 = new Phone("Iphone 12", 1500) { Camera= 12 };

            Phone[] phones = new Phone[0];

            string option;

            do
            {

                Console.WriteLine("1. Telefonlara bax");
                Console.WriteLine("2. Adina gore axtaris et");
                Console.WriteLine("3. Telefon elave et");
                Console.WriteLine("0. Cix");


                option = Console.ReadLine();


                switch (option)
                {

                    case "1":

                        foreach (var item in phones)
                        {
                            Console.WriteLine($"Name:{item.Name}- Price:{item.Price}-Camera:{item.Camera}");
                            
                        }
                        break;
                    case "2":

                        Console.WriteLine("Telefon adini daxil edin:");
                        string wantedname = Console.ReadLine();
                        foreach (var item in phones)
                        {
                            if (item.Name.Contains(wantedname))
                            Console.WriteLine($"Name:{item.Name}- Price:{item.Price}-Camera:{item.Camera}");
                            

                        }
                        break;
                    case "3":

                        for (int i = 0; i < phones.Length; i++)
                        {
                            string addphone;

                            Console.WriteLine("Elave etmek istediyiniz telefon adi elave edin");
                            addphone = Console.ReadLine();

                           double addprice;

                            Console.WriteLine("Qiymet elave edin");
                            string addpricestr = Console.ReadLine();
                            addprice = Convert.ToDouble(addpricestr);   
                           

                            Phone phnew = new Phone(addphone, addprice);
                            phones[i] = phnew;
                        }
                        break;
                    case "0":
                        option = "-1";
                        Console.WriteLine("Eminsiz y/n?");

                        if (Console.ReadLine()=="y")
                        {
                            option = "0";   
                        }

                        break;

                        default:
                        Console.WriteLine("Yanlis secim etdiniz, yeniden secin!");
                        break;
                }

                
            
            
            }
            while (option !="0");
        } 
       





        
    }
}
