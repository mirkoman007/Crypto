using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models
{

    public partial class Exchanges
    {
        public string Status { get; set; }
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public List<Exchange> Exchanges { get; set; }
    }

    public partial class Exchange
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri IconUrl { get; set; }
        public bool Verified { get; set; }
        public long LastTickerCreatedAt { get; set; }
        public long NumberOfMarkets { get; set; }
        public double Volume { get; set; }
        public string WebsiteUrl { get; set; }
        public long Rank { get; set; }
        public double MarketShare { get; set; }
    }
}
