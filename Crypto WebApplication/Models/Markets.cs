using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models
{

    public partial class Markets
    {
        public string Status { get; set; }
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public List<Currency> Currencies { get; set; }
        public List<Market> Markets { get; set; }
    }

    public partial class Currency
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public string Type { get; set; }
        public Uri IconUrl { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Sign { get; set; }
    }

    public partial class Market
    {
        public long Id { get; set; }
        public string Uuid { get; set; }
        public long Rank { get; set; }
        public string BaseSymbol { get; set; }
        public string QuoteSymbol { get; set; }
        public string SourceName { get; set; }
        public Uri SourceIconUrl { get; set; }
        public long TickerCreatedAt { get; set; }
        public double TickerClose { get; set; }
        public double? TickerBaseVolume { get; set; }
        public double TickerQuoteVolume { get; set; }
        public double MarketShare { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
    }

    public partial class Stats
    {
        public double Volume { get; set; }
    }

}
