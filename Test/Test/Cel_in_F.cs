using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Cel_in_F
    {
        public Cel_in_F() {
            Console.WriteLine("Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
        }
    }
}
