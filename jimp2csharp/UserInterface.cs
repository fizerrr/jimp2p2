using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace jimp2csharp
{
    interface UserInterface
    {
        
        public static void display_menu()
        {
            Console.WriteLine(" Co chcesz zrobić ? :) ");
            Console.WriteLine("1.Wyświetl baze danych");
            Console.WriteLine("2.Dodaj rekord");
            Console.WriteLine("3.Wyszukaj tytuł/y");
            Console.WriteLine("4.Zamknji");
        }

        public static String operation_selection() 
        {
            String userselection;


            userselection = Console.ReadLine();


            return userselection;
        }

        public static void add_reord(List<dvd> dvds)
        {
            Console.WriteLine("Tytuł:");
            String title_converter = Console.ReadLine();
            Console.WriteLine("Reżyseria:");
            String direction_converter = Console.ReadLine();
            Console.WriteLine("Gatunek:");
            String type_converter = Console.ReadLine();
            Console.WriteLine("Muzyka:");
            String music_converter = Console.ReadLine();
            Console.WriteLine("Data:");
            String date_of_production_converter = Console.ReadLine();
            Console.WriteLine("Czas trwania w minutach:");
            String time_converter = Console.ReadLine();
      

           

            dvds.Add(new dvd(title_converter,direction_converter,type_converter,music_converter,date_of_production_converter,time_converter));


            Console.WriteLine("Element został dodany!");
            Console.WriteLine();

        }

  

        public static void display_reords(List<dvd> dvds)
        {
            if (!dvds.Any()) Console.WriteLine("Baza danych jest pusta :((");
            else
            {
                Console.WriteLine();
                foreach (dvd advd in dvds)
                {
                    Console.WriteLine(advd);
                }
            }
        }

        public static void searching(List<dvd> dvds)
        {
            Console.WriteLine("Podaj szukany tytuł:");

            string wanted = Console.ReadLine();
            bool empty = true;
      
            Console.WriteLine("Znalezione rekordy:");

            foreach (dvd advd in dvds)
            {
                if (wanted == advd.return_title())
                {
                    Console.WriteLine(advd);
                    empty = false;
                  
                } 
            }

            if (empty)
            {
                Console.WriteLine("...");
                Console.WriteLine("Jednak nie znaleziono rekordów :((");
            }

            Console.WriteLine();
        }

        public static void save_list(List<dvd> dvds)
        {
           
            FileStream db = new FileStream("db.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter streamwriter = new StreamWriter(db);
            foreach (dvd advd in dvds)
            {
                streamwriter.WriteLine(advd.savetext());                
            }
            streamwriter.Flush();
            streamwriter.Close();
        }

        public static void load_list(List<dvd> dvds)
        {
            FileStream db = new FileStream("db.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader streamreader = new StreamReader(db);
            while (!streamreader.EndOfStream)
            {
                string title_converter = streamreader.ReadLine();
                string direction_converter = streamreader.ReadLine();
                string type_converter = streamreader.ReadLine();
                string music_converter = streamreader.ReadLine();
                string date_of_production_converter =streamreader.ReadLine();
                string time_converter = streamreader.ReadLine();



                dvds.Add(new dvd(title_converter, direction_converter, type_converter, music_converter, date_of_production_converter, time_converter));



            }

        }
    }
}
