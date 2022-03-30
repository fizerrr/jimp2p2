using System;
using System.Collections.Generic;
using System.Text;

namespace jimp2csharp
{
    interface UserInterface
    {

        public static void display_menu()
        {
            Console.WriteLine("User Interface:");
            Console.WriteLine("Choose what's you want to do ");
            Console.WriteLine("1.Display database");
            Console.WriteLine("2.Add a record");
            Console.WriteLine("3.Searching");
            Console.WriteLine("4.Safety save and Exit");
        }

        public static String operation_selection() 
        {
            String userselection;


            userselection = Console.ReadLine();


            return userselection;
        }

        public static void add_reord(List<dvd> list)
        {
            String title_converter;
            String direction_converter;
            String music_converter;
            String date_of_production_converter;
            String time_converter;
            String price_converter;

            title_converter = Console.ReadLine();
            direction_converter = Console.ReadLine();
            music_converter = Console.ReadLine();
            date_of_production_converter = Console.ReadLine();
            time_converter = Console.ReadLine();
            price_converter = Console.ReadLine();

            list.Add(new dvd(title_converter,direction_converter,music_converter,date_of_production_converter,time_converter,price_converter));
           

        }

        public static void display_reords(List<dvd> dvds)
        {

            Console.WriteLine();
            foreach (dvd advd in dvds)
            {
                Console.WriteLine(advd);
            }

        }

        public static void searching(List<dvd> dvds)
        {

            string wanted = Console.ReadLine();

            Console.WriteLine();
            foreach (dvd advd in dvds)
            {
                if (wanted == advd.return_title())
                {
                    Console.WriteLine(advd);
                } 
            }

        }

    }
}
