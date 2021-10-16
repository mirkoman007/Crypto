using Crypto_SOAP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace Crypto_SOAP
{
    /// <summary>
    /// Summary description for CryptoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CryptoService : System.Web.Services.WebService
    {

        [WebMethod]
        public XmlDocument Search(string search)
        {
            XmlDocument xmlDocument = GenerateXml();

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
            nsmgr.AddNamespace("ns", "http://schemas.datacontract.org/2004/07/Crypto_SOAP.Models");

            //XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/ns:ArrayOfCoin/ns:Coin[ns:Code='BTC']", nsmgr);
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes($"/ns:ArrayOfCoin/ns:Coin[ns:CirculatingSupply>{search}]", nsmgr);


            XmlDocument xmlRez = new XmlDocument();
            xmlRez.AppendChild(xmlRez.CreateElement("ArrayOfCoin"));
            foreach (XmlNode item in xmlNodeList)
            {
                xmlRez.DocumentElement.AppendChild(xmlRez.ImportNode(item, true));
            }

            return xmlRez;
        }

        private XmlDocument GenerateXml()
        {
            List<Coin> coins = new List<Coin> { 
                new Coin("Bitcoin", "BTC", 18844725) ,
                new Coin("Ethereum", "ETH", 117940742),
                new Coin("Binance Coin", "BNB", 168137036),
                new Coin("Solana", "SOL", 300272947),
                new Coin("Polkadot", "DOT", 987579314)
            };

            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Coin>));

            XmlDocument xmlDocument = new XmlDocument();
            using (XmlWriter writer = xmlDocument.CreateNavigator().AppendChild())
            {
                serializer.WriteObject(writer, coins);
            }

            return xmlDocument;
        }
    }
}
