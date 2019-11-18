using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_73
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicTrack song = new MusicTrack(artist: "Rob Miles", title: "My Way");
            Console.WriteLine("Track: {0:F}", song);
            Console.WriteLine("Artist: {0:A}", song);
            Console.WriteLine("Title: {0:T}", song);


            double bankBalance = 123.45;
            CultureInfo usProvider = new CultureInfo("en-US");
            Console.WriteLine("US balance: {0}", bankBalance.ToString("C", usProvider));
            CultureInfo ukProvider = new CultureInfo("en-GB");
            Console.WriteLine("UK balance: {0}", bankBalance.ToString("C", ukProvider));

            string name = "Rob";
            int age = 21;
            Console.WriteLine("Your name is {0} and your age is {1,-5:D}", name, age);

            Console.ReadKey();
        }
    }
}
