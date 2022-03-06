using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models
{

    public partial class Coins
    {
        public string Status { get; set; }
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public Stats Stats { get; set; }
        public Base Base { get; set; }
        public List<Coin> Coins { get; set; }
    }

    public partial class Base
    {
        public string Symbol { get; set; }
        public string Sign { get; set; }
    }

    public partial class Coin
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
        public long Volume { get; set; }
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

    public partial class AllTimeHigh
    {
        public string Price { get; set; }
        public long? Timestamp { get; set; }
    }

    public partial class Link
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }

    public partial class Stats
    {
        public long Total { get; set; }
        public long Offset { get; set; }
        public long Limit { get; set; }
        public string Order { get; set; }
        public string Base { get; set; }
        public long TotalMarkets { get; set; }
        public long TotalExchanges { get; set; }
        public string TotalMarketCap { get; set; }
        public string Total24HVolume { get; set; }
    }

}
