using System.Collections.Generic;
using System;

namespace jimp2csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            UserInterface.display_menu();
            bool exit = false;
            List<dvd> dvdList = new List<dvd>();
            while (!exit)
            {

                switch (UserInterface.operation_selection())
                {
                    case "1":


                        UserInterface.display_reords(dvdList);

                        break;

                    case "2":


                        UserInterface.add_reord(dvdList);


                        break;



                    case "3":

                        UserInterface.searching(dvdList);

                        break;


                    case "4":
                        //save

                        exit = true;


                        break;


                    default:


                        Console.WriteLine("Wrong request !,Try again !");


                        break;


                    case "test":


                        exit = true;

                        break;


                }


            }
        }
    }
}
