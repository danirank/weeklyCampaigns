using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weeklyCampaigns.Core.Models
{
    public class CampaignPeriod
    {
        public DateOnly? From { get; set; }
        public DateOnly? To { get; set; }

        public override string ToString()
        => (From, To) switch
        {
            (not null, not null) => $"{From:yyyy-MM-dd}–{To:yyyy-MM-dd}",
            (not null, null) => $"{From:yyyy-MM-dd}–",
            (null, not null) => $"–{To:yyyy-MM-dd}",
            _ => "Okänd period"
        };
    }
}
