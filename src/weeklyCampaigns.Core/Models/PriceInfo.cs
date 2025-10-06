using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace weeklyCampaigns.Core.Models
{
    public class PriceInfo
    {
        public decimal Price { get; init; }
        public string Unit { get; init; } = "st";

        public decimal UnitSize { get; init; }

        public decimal UnitPrice { get; init; }






    }
}
