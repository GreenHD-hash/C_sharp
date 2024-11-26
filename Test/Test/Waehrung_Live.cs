using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test
{
    public class Waehrung_Live
    {
        private static readonly HttpClient client = new HttpClient();

        public Waehrung_Live()
        {
            Console.WriteLine("Bitte geben Sie den Betrag ein");
            if (!double.TryParse(Console.ReadLine(), out double euro))
            {
                Console.WriteLine("Ungültige Eingabe für Betrag.");
                return;
            }

            Console.WriteLine("Was möchten Sie tun?");
            Console.WriteLine("Euro_in_USD; USD_in_Euro");
            string input = Console.ReadLine();

            if (input == "Euro_in_USD")
            {
                double rate = GetExchangeRate("EUR", "USD").Result;
                if (rate > 0)
                {
                    double usd = euro * rate;
                    Console.WriteLine($"Betrag in USD: {usd}");
                }
            }
            else if (input == "USD_in_Euro")
            {
                double rate = GetExchangeRate("USD", "EUR").Result;
                if (rate > 0)
                {
                    double eur = euro / rate;
                    Console.WriteLine($"Betrag in Euro: {eur}");
                }
            }
            else
            {
                Console.WriteLine("Unbekannter Befehl");
            }
        }

        private async Task<double> GetExchangeRate(string fromCurrency, string toCurrency)
        {
            try
            {
                string apiKey = "091aa32392ab42e1c11b8ef5"; // Replace with your actual API key
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{fromCurrency}/{toCurrency}";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<ExchangeRateResponse>(jsonString);
                return data.conversion_rate;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Abrufen des Wechselkurses: {ex.Message}");
                return -1;
            }
        }
    }

    public class ExchangeRateResponse
    {
        public double conversion_rate { get; set; }
    }
}
