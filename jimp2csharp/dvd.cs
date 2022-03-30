using System;
using System.Collections.Generic;
using System.Text;

namespace jimp2csharp
{
    class dvd
    {
        String title;
        String direction;
        String music;
        String date_of_production;
        String time;
        String price;
        
        public dvd(string title,string direction,string music,string date_of_production,string time, string price)
        {
            this.title = title;
            this.direction = direction;
            this.music = music;
            this.date_of_production = date_of_production;
            this.time = time;
            this.price = price;
        }

        public dvd()
        {
        }

        public override string ToString()
        {
            return "|" + "Title:" + title;
        }
        public void dvd_say()
        {
            Console.WriteLine(title);
            Console.WriteLine(direction);
            Console.WriteLine(music);
            Console.WriteLine(date_of_production);
            Console.WriteLine(time);
            Console.WriteLine(price);
        }

        public string return_title()
        {
            return title;
        }


    }
}
