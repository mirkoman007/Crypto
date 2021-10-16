using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Crypto_SOAP.Models
{
    [DataContract]
    public class Coin
    {
        [DataMember(Order = 0)]
        public string Name { get; set; }
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public int CirculatingSupply { get; set; }

        public Coin(string name, string code, int circulatingSupply)
        {
            Name = name;
            Code = code;
            CirculatingSupply = circulatingSupply;
        }
    }
}