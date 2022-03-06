using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models
{
    public partial class Stats
    {
        public string Status { get; set; }
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public long TotalCoins { get; set; }
        public long TotalMarkets { get; set; }
        public long TotalExchanges { get; set; }
        public string TotalMarketCap { get; set; }
        public string Total24HVolume { get; set; }
    }
}
