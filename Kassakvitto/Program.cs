using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassakvitto2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklarera variabler
            int total = 0;
            decimal totalSumma = 0;
            decimal avrundatBelopp = 0;
            int erhålletBelopp = 0;
            int tillbaka = 0;


            // Totalsumma 

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma: ");
                    totalSumma = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Totalsumma felaktig.\n");
                    Console.ResetColor();
                }
            }

            //avrundning
            total = (int)Math.Round(totalSumma);
            avrundatBelopp = total - totalSumma;

            if (totalSumma < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.\n");
                Console.ResetColor();

                return;
            }

            //Erhållet belopp
            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    erhålletBelopp = int.Parse(Console.ReadLine());
                    break;
                }

                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt.\n");
                    Console.ResetColor();
                }
            }


            if (total > erhålletBelopp)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.\n");
                Console.ResetColor();

                return;

            }

            //Kvitto 

            tillbaka = erhålletBelopp - total;

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0,-17}: {1,15:c}", "Totalt", totalSumma);
            Console.WriteLine("{0,-17}: {1,15:c}", "Öresavrundning", avrundatBelopp);
            Console.WriteLine("{0,-17}: {1,15:c0}", "Att betala", total);
            Console.WriteLine("{0,-17}: {1,15:c0}", "Kontant", erhålletBelopp);
            Console.WriteLine("{0,-17}: {1,15:c0}", "Tillbaka", tillbaka);
            Console.WriteLine("----------------------------------");


            // Växel som kunden ska ha tillbaka

            int femhundraLappar = 0;
            int hundraLappar = 0;
            int femtioLappar = 0;
            int tjugoLappar = 0;
            int tioKronor = 0;
            int femKronor = 0;
            int enKronor = 0;

            femhundraLappar = tillbaka / 500;
            tillbaka = tillbaka % 500;
            hundraLappar = tillbaka / 100;
            tillbaka = tillbaka % 100;
            femtioLappar = tillbaka / 50;
            tillbaka = tillbaka % 50;
            tioKronor = tillbaka / 10;
            tillbaka = tillbaka % 10;
            tjugoLappar = tillbaka / 20;
            tillbaka = tillbaka % 20;
            femKronor = tillbaka / 5;
            tillbaka = tillbaka % 5;
            enKronor = tillbaka / 1;
            tillbaka = tillbaka % 1;


            if (femhundraLappar > 0)
            {
                 Console.WriteLine(" {0,-15} : {1}", "500-lappar", femhundraLappar);
            }
            if (hundraLappar > 0)
            {
                 Console.WriteLine(" {0,-15} : {1}", "100-lappar", hundraLappar);
            {
            if (femtioLappar > 0)
            {
                 Console.WriteLine(" {0,-15} : {1}", "50-lappar", femtioLappar);
            }
            if (tjugoLappar > 0)
            {
                 Console.WriteLine(" {0,-15} : {1}", "20-lappar", tjugoLappar);
            }
            if (tioKronor > 0)
            {
                 Console.WriteLine(" {0,-15} : {1}", "10-kronor", tioKronor);
            }
            if (femKronor > 0)
            {
                  Console.WriteLine(" {0,-15} : {1}", "5-kronor", femKronor);
            }
            if (enKronor > 0)
            {
                  Console.WriteLine(" {0,-15} : {1}", "1-kronor", enKronor);
            }



                }

            }

        }
    }
}




         
                

