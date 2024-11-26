using System;

namespace Test
{
    internal class Heizölrechnung
    {
        public Heizölrechnung()
        {
            Console.WriteLine("Kundenname");
            string name = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie die Anzahl der Liter im Tanklastenzug vor Lieferung ein");
            if (!double.TryParse(Console.ReadLine(), out double literV))
            {
                Console.WriteLine("Ungültige Eingabe für Liter vor Lieferung.");
                return;
            }
            Console.WriteLine("Bitte geben Sie die Anzahl der Liter im Tanklastenzug nach Lieferung ein");
            if (!double.TryParse(Console.ReadLine(), out double literN))
            {
                Console.WriteLine("Ungültige Eingabe für Liter nach Lieferung.");
                return;
            }
            Console.WriteLine("Bitte geben Sie den Preis pro Liter ein");
            if (!double.TryParse(Console.ReadLine(), out double preis))
            {
                Console.WriteLine("Ungültige Eingabe für Preis pro Liter.");
                return;
            }

            double sumG = literV - literN;
            double sum = sumG * preis;
            Console.WriteLine($"---- {name} ----");
            Console.WriteLine($"Gelieferte Menge: {sumG}");
            Console.WriteLine($"Der netto Preis beträgt {sum}");

            Console.WriteLine("Mehrwertsteuer? (True/False)");
            if (bool.TryParse(Console.ReadLine(), out bool mwst) && mwst)
            {
                double mehrwertsteuer = sum * 0.19;
                Console.WriteLine($"Mehrwertsteuer: {mehrwertsteuer}");
                Console.WriteLine($"Rechnungsbetrag incl. Mwst: {sum + mehrwertsteuer}");
            }
        }
    }
}
