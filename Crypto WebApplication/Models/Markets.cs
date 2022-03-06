using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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
        public List<Market> Markets { get; set; }
    }

    public partial class Market
    {
        public string Uuid { get; set; }
        public long Rank { get; set; }
        public Base Base { get; set; }
        public Base Quote { get; set; }
        public Exchange Exchange { get; set; }
        public string MarketShare { get; set; }
        public string BtcPrice { get; set; }
        public bool Recommended { get; set; }
        public string Price { get; set; }

        [JsonPropertyName("24hVolume")]
        public string The24HVolume { get; set; }
    }

    public partial class Stats
    {

        [JsonPropertyName("24hVolume")]
        public string The24HVolume { get; set; }
    }

}
