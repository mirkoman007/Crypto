using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models.Soap
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Crypto_SOAP.Models")]
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
