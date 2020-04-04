using System;

namespace Lab01MOS
{
    class Program
    {
        static void Main(string[] args)
        {


            string imiegraczaA = "";
            string imiegraczaB = "";

            char znakgraczaA = 'x';
            char znakgraczaB = 'o';

            char[,] tablica = new char[3, 3]
            {

                {'1','2','3' },
                {'4','5','6'},
                {'7','8','9' },

            };
           





            Console.WriteLine("Podaj imie pierwszego gracza: ");
            imiegraczaA = Console.ReadLine();

            Console.WriteLine("Podaj imie drugiego gracza: ");
            imiegraczaB = Console.ReadLine();

        }
    }
}
