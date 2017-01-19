using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the shelf, in inches?");
            string shelfLengthString = Console.ReadLine();
            double shelfLength = Convert.ToDouble(shelfLengthString);

            Console.WriteLine("What is the length of game, in inches?");
            string gameLengthString = Console.ReadLine();
            double gameLength = Convert.ToDouble(gameLengthString);

            double gamesOnShelf = Math.Truncate(shelfLength / gameLength);
            Console.WriteLine(gamesOnShelf + " games can be displayed on 1 shelf.\n");

            Console.WriteLine("How many shelves are there?");
            string shelfNumberString = Console.ReadLine();
            double shelfNumber = Convert.ToDouble(shelfNumberString);

            Console.WriteLine("How many games do you want to display?");
            string gameNumberString = Console.ReadLine();
            double gameNumber = Convert.ToDouble(gameNumberString);

            double gameOnShelves = gamesOnShelf * shelfNumber;
            double remainder = gameNumber - gameOnShelves;

            Console.WriteLine(gameOnShelves + " games can be displayed on shelves. " + remainder + " games will have to be stored in the back.");
            Console.ReadKey();
        }
    }
}
