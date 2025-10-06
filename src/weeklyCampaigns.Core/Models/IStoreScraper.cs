using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weeklyCampaigns.Core.Models
{
    public interface IStoreScraper
    {
        public List<ProductOffer> GetWeeklyCampaigns();
    }
}
