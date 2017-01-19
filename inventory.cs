using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 50000;
            Console.WriteLine("What percentage of people prefer Fantasy Games?");
            string fantasyString = Console.ReadLine();
            double fantasyPercent = Convert.ToDouble(fantasyString);
            Console.WriteLine("What percentage of people prefer Shooting Games?");
            string shootingString = Console.ReadLine();
            double shootingPercent = Convert.ToDouble(shootingString);
            Console.WriteLine("What percentage of people prefer Arcade Games?");
            string arcadeString = Console.ReadLine();
            double arcadePercent = Convert.ToDouble(arcadeString);

            double fantasy = (fantasyPercent/100.0) * total;
            double shooting = (shootingPercent/100.0) * total;
            double arcade = (arcadePercent/100.0) * total;

            Console.WriteLine("The business should buy " + fantasy + " Fantasy Games.");
            Console.WriteLine("The business should buy " + shooting + " Shooting Games.");
            Console.WriteLine("The business should buy " + arcade + " Arcade Games.");
            Console.ReadKey();
        }
    }
}
