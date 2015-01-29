using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lönerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lönerevision";

            // Initierar variabler
            int antalLoner;

            do
            {
                Console.Clear();

            // Antalet löner skrivs in
            antalLoner = ReadInt("Ange antal löner att mata in: ");

            // Om antalet löner är större än två så anropas metoden ProcessSalaries.        
            if (antalLoner > 2)
            {
                 ProcessSalaries(antalLoner);
            }
            else
            {
                 Console.BackgroundColor = ConsoleColor.Red;
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning.");
                 Console.ResetColor();
            }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tryck vilken tangent som helst för ny beräkning, escape för att avsluta.");
                Console.ResetColor();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

            // Läsa in data
            static int ReadInt(string prompt)
            {
            while (true)
            {
              try
                 {
                  Console.Write(prompt);
                  return int.Parse(Console.ReadLine());
                  }
                  catch (Exception)
                  {
                  Console.BackgroundColor = ConsoleColor.Red;
                  Console.ForegroundColor = ConsoleColor.White;
                  Console.WriteLine("Fel! '{0}' kan inte tolkas som ett heltal");
                  Console.ResetColor();
                }
            }
        }

           static void ProcessSalaries(int count)
            {
            int[] loner = new int[count];

            Console.WriteLine("");

            for (int i = 0; i < count; ++i)
            {
                string prompt = String.Format("Ange lön nummer {0}: ", i + 1);
                loner[i] = ReadInt(prompt);
            }

            //Gör en kopia av arrayn.
            int[] copy = new int[count];
            Array.Copy(loner, copy, count);

            //Sorterar arrayn 
            Array.Sort(loner);

            //Beräknar "Medianlön".
            decimal median;

            if (loner.Length % 2 == 0)
            {
                int l = loner.Length / 2;
                median = (loner[l - 1] + loner[l]) / 2.0m;
            }
            else
            {
                median = loner[(loner.Length) / 2];
            }

            //skriver ut
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Medianlön:      {0, 6:c0}", median);
            Console.WriteLine("Medellön:       {0, 6:c0}", loner.Average());
            Console.WriteLine("Lönespridning:  {0, 6:c0}", loner.Max() - loner.Min());
            Console.WriteLine("------------------------------");

            //Skriver ut lönerna som de skrevs in.
            for (int i = 0; i < copy.Length; i++)
            {
            if (i % 3 != 0)
            {
                 Console.Write("{0, 8}", loner[i]);
            }
            else
            {
                 Console.WriteLine();
                 Console.Write("{0, 8}", loner[i]);
            }
          }
              Console.WriteLine();
           }
         }
       }




     













