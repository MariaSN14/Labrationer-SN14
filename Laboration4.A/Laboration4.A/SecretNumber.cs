using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4.A
{
    public class SecretNumber
    {

        //Antalet gissningar är max 7
        public const int MaxNumberOfGuesses = 7;

        //Deklarera fält
        int _count;
        int _number;

        //Kolla om SecretNumber-objekt är rätt initierat
        public SecretNumber()
        {
            Initialize();
        }

        //Slumpmässiga tal mellan 1-100
        public void Initialize()
        {
            Random random = new Random();
            _number = random.Next(1, 101);

            _count = 0;
        }

        //Anropa MakeGuess för att göra en gissning av det hemliga talet.
        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

            if (number <= 0 || number >= 101)
            {
                throw new ArgumentOutOfRangeException();
            }

            _count++;

            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök.", _count);
                return true;
            }

            if (number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar", _number, MaxNumberOfGuesses - _count);
            }
            else
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar", _number, MaxNumberOfGuesses - _count);
            }



            //När gissningarna är slut visas det hemliga talet 
            if (_count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Det hemliga talet är {0}", _number);
            }

            return false;

        }
    }
}

