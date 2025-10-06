using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weeklyCampaigns.Core.Models;  

namespace weeklyCampaigns.Core.Services
{
    public class ProductOfferService
    {
        public Ica Ica { get; set; } = new();
        public Willys Willys { get; set; } = new();

        public IEnumerable<IStoreScraper> AllProducts { get; set; }

        public ProductOfferService()
        {
            AllProducts = new List<IStoreScraper> { Ica, Willys };
        }

        public List<ProductOffer> GetAllWeeklyCampaigns()
        {
            var allOffers = new HashSet<ProductOffer>(new ProductOfferComparer());

            foreach (var store in AllProducts)
            {
                var campaigns = store.GetWeeklyCampaigns();
                allOffers.UnionWith(campaigns); 
            }

            return allOffers.ToList();
        }

    }

    public class ProductOfferComparer : IEqualityComparer<ProductOffer>
    {
        public bool Equals(ProductOffer x, ProductOffer y)
        {
            if (x is null || y is null) return false;
            return x.Name == y.Name && x.StoreName == y.StoreName;
        }

        public int GetHashCode(ProductOffer obj)
        {
            return HashCode.Combine(obj.Name, obj.StoreName);
        }
    }

}
