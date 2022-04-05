using System.Collections.Generic;
using System;
using System.IO;

namespace jimp2csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            

            bool exit = false;
            
            List<dvd> dvdList = new List<dvd>();
            UserInterface.load_list(dvdList);
            Console.WriteLine("Interfejs użytkownika:");
            Console.WriteLine();

            while (!exit)
            {
                UserInterface.display_menu();

                switch (UserInterface.operation_selection())
                {
                    case "1":


                        UserInterface.display_reords(dvdList);

                        break;

                    case "2":


                        UserInterface.add_reord(dvdList);
                        UserInterface.save_list(dvdList);



                        break;



                    case "3":

                        UserInterface.searching(dvdList);

                        break;


                    case "4":
                        
                        UserInterface.save_list(dvdList);
                        exit = true;

                       
                        break;





                        break;


                    default:


                        Console.WriteLine("Wrong request !,Try again !");


                        break;


                }


            }
        }
    }
}
