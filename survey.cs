using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace survey
{
    class Program
    {
        private static int months;

        static void Main(string[] args)
        {
            Console.WriteLine("Have you previously worked in a game store?");
            string gameStore = Console.ReadLine();

            Console.WriteLine("Do you have any experience in sales?");
            string experience = Console.ReadLine();

            if(experience == "Y")
            {
                Console.WriteLine("How many months of experience do you have?");
                string monthsString = Console.ReadLine();
                months = Convert.ToInt32(monthsString);
            }

            Console.WriteLine("Do you like video games?");
            string videoGames = Console.ReadLine();

            if(gameStore == "Y" && videoGames == "Y")
            {
                Console.WriteLine("You are a good fit for UCF Games!");
            }
            else if(months > 3 && videoGames == "Y")
            {
                Console.WriteLine("You are a good fit for UCF Games!");
            }
            else if(experience == "Y" && videoGames == "Y")
            {
                Console.WriteLine("You are a good fit for UCF Games!");
            }
            else if(experience == "Y" %% months < 3)
            {
                Console.WriteLine("You do not seem like a good fit for UCF Games!");
            }
            else
            {
                Console.WriteLine("You do not seem like a good fit for UCF Games!");
            }
            Console.ReadKey();
        }
    }
}
