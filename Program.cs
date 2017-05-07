using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Hier een aantal oefeningen met loops etc");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1) Geef een maximum voor de volgende loop op (alleen getallen in de reeks van 3 en 5 onder het opgegeven maximum)");
            double maximumLoop2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            double loopcheck = 0;

            while
                (loopcheck < maximumLoop2)
            {
                loopcheck = loopcheck + 1;
                if
                (loopcheck % 3 != 0 && loopcheck % 5 != 0)
                    continue;
                Console.WriteLine(loopcheck);

            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Geef een getal tussen 0 en 20 op");
            
            double y;

            for (double x = Double.Parse(Console.ReadLine()); x < 20 && x > 0; x = x + 2)
                for (y = 1; y < 12; y = y + 4)
                    Console.WriteLine(x + "," + y);



            Console.WriteLine();
            Console.ReadKey();

            loopcheck = 1;
            do
            {
                Console.WriteLine(loopcheck);
                loopcheck++;
            } while (loopcheck < 10);

            Console.WriteLine();
            Console.WriteLine("en nu de check of de 1 wel wordt opgeschreven omdat de while pas na de writeline komt");
            Console.ReadKey();

            loopcheck = 100;
            do
            {
                Console.WriteLine(loopcheck);
                loopcheck++;
            } while (loopcheck < 10);

            Console.WriteLine("als het goed is staat hier nu alleen 100");

            Console.WriteLine();
            Console.ReadKey();

            loopcheck = 0;

            Console.WriteLine("geef een maximum voor de volgende loop op");
            double maximumLoop = Double.Parse(Console.ReadLine());

            for (loopcheck = 0; loopcheck < maximumLoop; loopcheck = loopcheck + 1)
            {
                if (loopcheck % 7 == 0 || loopcheck % 5 == 0 || loopcheck / 3 < 5)
                    continue;
                Console.WriteLine(loopcheck);
            }

            Console.ReadKey();
            Console.WriteLine("nu met een for loop zonder continue (dit zou alleen multiples of 7 en 5 moeten geven of als de loopcheck kleiner is dan 50 (het tegenover gestelde dus) ");

            for (loopcheck = 0; loopcheck < maximumLoop; loopcheck++)
            {
                if (loopcheck % 7 == 0 || loopcheck % 5 == 0 || loopcheck / 3 < 5)
                    Console.WriteLine(loopcheck);
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(" Hierbij een oefening met Arrays ");

            string[] tvSeries =
            {
                "Fargo",
                "The Sopranos",
                "Deadwood",
                "Breaking Bad",
                "The Leftovers",
                "Lost",
                "Better Call Saul",
                "Game of Thrones",
                "Berserk",
                "Band of Brothers",
                "Attack on Titan"
            };

            int arrayLengte = tvSeries.Length - 1;
            Console.WriteLine("Geef een getal op van 0 tot " + arrayLengte);
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine();            
            Console.WriteLine(tvSeries[input]);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("hoe lang is de Array?");
            Console.WriteLine("de Array lijst loopt van 0 naar " + arrayLengte);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("De complete Array is als volgt");
            for (int index = 0; index < tvSeries.Length; index = index + 1) 
            Console.WriteLine(tvSeries[index]);

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("De complete Array kan als het goed is ook worden weergegeven met een foreach opdracht");
            foreach (string goedeSeries in tvSeries)
                Console.WriteLine(goedeSeries);


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
