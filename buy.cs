using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buy
{
    class buy
    {
        private static double newPrice = 50.00;
        private static double usedPrice = 10.00;
        private static double total = 0.00;
        private static string selection = "0"; 

        static void Main(string[] args)
        {
            while (selection != "3")
            { 
                Console.WriteLine("1) Buy New Games");
                Console.WriteLine("2) Buy Used Games");
                Console.WriteLine("3) Quit");
                selection = Console.ReadLine();

                if (selection == "1")
                {
                    Console.WriteLine("\nHow many games would you like to buy?");
                    string newGamesString = Console.ReadLine();
                    double newGames = Convert.ToDouble(newGamesString);
                    total += newGames * newPrice;
                }
                else if (selection == "2")
                {
                    Console.WriteLine("\nHow many games would you like to buy?");
                    string usedGamesString = Console.ReadLine();
                    double usedGames = Convert.ToDouble(usedGamesString);
                    total += usedGames * usedPrice;
                }
                else if (selection == "3")
                {
                    Console.WriteLine("\nYour total cost is $" + total);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nSorry " + selection + " is not a valid choice.\n");
                }
            }
        }
    }
}
