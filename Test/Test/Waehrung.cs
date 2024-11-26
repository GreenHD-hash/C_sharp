using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Waehrung
    {
        public Waehrung()
        {
            Console.WriteLine("Bitte geben Sie den Betrag in Euro ein");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Was möchten Sie tun?");
            Console.WriteLine("Euro_in_USD; USD_in_Euro");
            string input = Console.ReadLine();
            if (input == "Euro_in_USD")
            {
                double usd = euro * 1.09;
                Console.WriteLine(usd);
            }
            else if (input == "USD_in_Euro")
            {
                double usd = euro / 1.09;
                Console.WriteLine(usd);
            }
            else
            {
                Console.WriteLine("Unbekannter Befehl");
            }
        }
    }
}
