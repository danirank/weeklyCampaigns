using weeklyCampaigns.Core.Models;
using weeklyCampaigns.Core.Services;

namespace TestCodeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ProductOfferService();
            var allOffers = service.GetAllWeeklyCampaigns();

            foreach (var offer in allOffers)
            {
                Console.WriteLine($"{offer.Name} ({offer.StoreName}) - {offer.Price.Price} kr/{offer.Price.Unit} ({offer.Price.UnitSize} {offer.Price.Unit} à {offer.Price.UnitPrice} kr) - {offer.Period}");
            }

            var json = allOffers.ToJson();
            Console.WriteLine(json);
        }

        
    }
    public static class JsonSerializer
    {
        public static string ToJson(this object obj)
        {
            return System.Text.Json.JsonSerializer.Serialize(obj, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });
        }
    }
}
