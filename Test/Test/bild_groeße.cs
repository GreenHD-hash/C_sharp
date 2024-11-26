using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class bild_groeße
    {
        public bild_groeße()
        {
            //Dateigröße = Anzahl der Bildpunkte * Farbtiefe + Dateiheader
            Console.WriteLine("Bitte geben Sie die Farbtiefe ein");
            Console.WriteLine("Real Color; High Color; True Color");
            string farbtiefe = Console.ReadLine();
            if (farbtiefe == "Real Color")
            {
                farbtiefe = "15";
            }
            else if (farbtiefe == "High Color")
            {
                farbtiefe = "16";
            }
            else if (farbtiefe == "True Color")
            {
                farbtiefe = "24";
            }
            else
            {
                Console.WriteLine("Unbekannte Farbtiefe");
            }

            Console.WriteLine("Bitte geben Sie die Größe des Dateiheaders in byte ein");
            int Dateiheader = Convert.ToInt32(Console.ReadLine());

            int Dateigröße = (1024 * 768) * Convert.ToInt32(farbtiefe) + (Dateiheader * 8);
            Console.WriteLine("Die Dateigröße beträgt " + Dateigröße + " Bit");
            Console.WriteLine("Die Dateigröße beträgt " + Dateigröße / 8000 + " KB");
            Console.WriteLine("Die Dateigröße beträgt " + Dateigröße / 8 + " Byte");
        }
    }
}
