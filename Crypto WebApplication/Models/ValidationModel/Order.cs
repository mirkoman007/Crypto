using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Models.ValidationModel
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Crypto_Web_API.Models")]
    public class Order
    {
        [DataMember(Order = 0)]
        public string Cryptocurrency { get; set; }
        [DataMember(Order = 1)]
        public float Price { get; set; }
        [DataMember(Order = 2)]
        public float Amount { get; set; }

        public Order()
        {
        }

        public Order(string cryptocurrency, float price, float amount)
        {
            Cryptocurrency = cryptocurrency;
            Price = price;
            Amount = amount;
        }
    }
}
