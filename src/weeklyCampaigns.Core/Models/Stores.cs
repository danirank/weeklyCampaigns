using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weeklyCampaigns.Core.Models
{
    public class Ica : StoreHelper,IStoreScraper
    {
        public Ica()
        {
            Name = StoreName.Ica;
            Url = "https://www.ica.se/handla/campaigns/";
            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Ica_Logo.svg/2560px-Ica_Logo.svg.png";
        }
        public List<ProductOffer> GetWeeklyCampaigns()
        {
            return new List<ProductOffer>
            {
                new ProductOffer
                {
                    Id = 1,
                    Name = "Kycklingfilé 1kg",
                    StoreName = StoreName.Ica,
                    Category = ProductCategory.Kött,
                    ImageUrl = "https://via.placeholder.com/150",
                    ProductUrl = Url,
                    Price = new PriceInfo { Price = 79.90m },
                    Period = new CampaignPeriod
                    {
                        From = DateOnly.FromDateTime(DateTime.Today),
                        To = DateOnly.FromDateTime(DateTime.Today.AddDays(7))
                    }
                },
                new ProductOffer
                {
                    Id = 2,
                    Name = "Bananer",
                    StoreName = StoreName.Ica,
                    Category = ProductCategory.Frukt,
                    ImageUrl = "https://via.placeholder.com/150",
                    ProductUrl = Url,
                    Price = new PriceInfo { Price = 19.90m },
                    Period = new CampaignPeriod
                    {
                        From = DateOnly.FromDateTime(DateTime.Today),
                        To = DateOnly.FromDateTime(DateTime.Today.AddDays(7))
                    }
                }
            };
        }
    }

    public class Willys : StoreHelper, IStoreScraper
    {
        public Willys()
        {
            Name = StoreName.Willys;
            Url = "https://www.willys.se/veckans-erbjudanden/";
            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Willys_Logo.svg/2560px-Willys_Logo.svg.png";
        }
        public List<ProductOffer> GetWeeklyCampaigns()
        {
            return new List<ProductOffer>
            {
                new ProductOffer
                {
                    Id = 3,
                    Name = "Falukorv 800g",
                    StoreName = StoreName.Willys,
                    Category = ProductCategory.Kött,
                    ImageUrl = "https://via.placeholder.com/150",
                    ProductUrl = Url,
                    Price = new PriceInfo { Price = 25.00m },
                    Period = new CampaignPeriod
                    {
                        From = DateOnly.FromDateTime(DateTime.Today),
                        To = DateOnly.FromDateTime(DateTime.Today.AddDays(7))
                    }
                },
                new ProductOffer
                {
                    Id = 4,
                    Name = "Äpplen Royal Gala",
                    StoreName = StoreName.Willys,
                    Category = ProductCategory. Frukt,
                    ImageUrl = "https://via.placeholder.com/150",
                    ProductUrl = Url,
                    Price = new PriceInfo { Price = 15.90m },
                    Period = new CampaignPeriod
                    {
                        From = DateOnly.FromDateTime(DateTime.Today),
                        To = DateOnly.FromDateTime(DateTime.Today.AddDays(7))
                    }
                }
            };
        }
    }

    

}
