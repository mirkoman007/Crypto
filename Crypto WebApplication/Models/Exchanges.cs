using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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
        public string Uuid { get; set; }
        public string Name { get; set; }
        public Uri IconUrl { get; set; }
        public bool Verified { get; set; }
        public bool Recommended { get; set; }
        public long NumberOfMarkets { get; set; }
        public Uri CoinrankingUrl { get; set; }
        public string BtcPrice { get; set; }
        public long Rank { get; set; }
        [JsonPropertyName("24hVolume")]
        public string Volume { get; set; }
        public string Price { get; set; }
    }
}
