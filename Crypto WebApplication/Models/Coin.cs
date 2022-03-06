using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models
{

    public partial class Coin
    {
        public string Status { get; set; }
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public CoinClass Coin { get; set; }
    }

    public partial class CoinClass
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public string Slug { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string IconType { get; set; }
        public Uri IconUrl { get; set; }
        public Uri WebsiteUrl { get; set; }
        public List<Link> Socials { get; set; }
        public List<Link> Links { get; set; }
        public bool ConfirmedSupply { get; set; }
        public long NumberOfMarkets { get; set; }
        public long NumberOfExchanges { get; set; }
        public string Type { get; set; }
        [JsonPropertyName("24hVolume")]
        public string Volume { get; set; }
        public string MarketCap { get; set; }
        public string Price { get; set; }
        public double? CirculatingSupply { get; set; }
        public double? TotalSupply { get; set; }
        public bool ApprovedSupply { get; set; }
        public long FirstSeen { get; set; }
        public long ListedAt { get; set; }
        public string Change { get; set; }
        public long Rank { get; set; }
        public List<string> History { get; set; }
        public AllTimeHigh AllTimeHigh { get; set; }
        public bool Penalty { get; set; }
    }
}
