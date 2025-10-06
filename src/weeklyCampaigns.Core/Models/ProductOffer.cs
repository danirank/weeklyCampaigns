using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weeklyCampaigns.Core.Models
{
    public class ProductOffer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StoreName StoreName { get; set; }
        public ProductCategory Category { get; set; }
        public string ImageUrl { get; set; }
        public string ProductUrl { get; set; }

        public PriceInfo Price { get; set; }

        public CampaignPeriod Period { get; set; }


    }
}
