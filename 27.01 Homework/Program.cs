using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace _27._01_Homework
{
    internal class Program
    {


        static void Main(string[] args)
        {
            
            //Taks2

            Car cr1 = new Car("BMW", "F10", 15000, 20, 15);

            //cr1.AddFuel();

            //Task3
            Student[] students = new Student[2];
               Student st1 = new Student("Leyla Quliyeva", "P231");
               Student st2 = new Student("Nicat Bayramov", "P562");
            for (int i = 0; i < students.Length; i++)
            {
                students[0] = st1;
                students[1] = st2;
            }

            

            string option;

            do
            {
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Telebeler uzre axtarıs et");
                Console.WriteLine(" 3. Telebe elave et");
                Console.WriteLine("0.Cix");

                option  = Console.ReadLine();

                switch (option)
                {
                          case "1":

                        foreach (var item in students)
                        {
                            Console.WriteLine($"FullName:{item.FullName} Group:{item.Group}");
                            
                        }
                        break;

                    case "2":

                        Console.WriteLine("Telebe adini qeyd edin:");
                        string wantedname = Console.ReadLine();
                        foreach (var item in students)
                        {
                            if (item.FullName.Contains(wantedname) || item.Group.Contains(wantedname))
                            {
                                Console.WriteLine($"FullName:{item.FullName} Group:{item.Group}");
                            }


                        }
                        break;

                         case "3":

                        for (int i = 0; i < students.Length; i++)
                        {
                            string addname;

                            do
                            {
                                Console.WriteLine("Elave etmek istediyiniz adi elave edin");
                                addname = Console.ReadLine();

                            } while (!char.IsLetter(addname[i]));

                            string addgroup;
                            do
                            {
                                Console.WriteLine("Group elave edin");
                                addgroup = Console.ReadLine();

                            } while (!char.IsUpper(addgroup[0])&& char.IsDigit(addgroup[i]));

                            Student stnew = new Student(addname, addgroup);
                            students[i] = stnew;

                        };
                        break;
                        case "0":

                        option = "-1";

                        Console.WriteLine("Eminsinizmi? y/n");
                        if (Console.ReadLine() == "y")
                        {
                            option = "0";
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz, yeniden secin!");
                        break;

                }



            } while (option!="0");






            
            

            

           
            
            


        }
    }
}
