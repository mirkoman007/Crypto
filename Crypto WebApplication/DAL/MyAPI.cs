using Crypto_WebApplication.Models.ValidationModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crypto_WebApplication.DAL
{
    public class MyAPI
    {
        internal static bool XsdValidation(Order newOrder)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(Order));
            MemoryStream data = new MemoryStream();
            XmlWriter xmlWriter = XmlWriter.Create(data);
            serializer.WriteObject(xmlWriter, newOrder);
            xmlWriter.Close();

            byte[] dataForRequest = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(data.ToArray()));

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:46809/api/orders/xsd");
            return sendRequest(dataForRequest, webRequest);
        }

        internal static bool RngValidation(Order newOrder)
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement element1 = doc.CreateElement(string.Empty, "Order", string.Empty);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(string.Empty, "Cryptocurrency", string.Empty);
            XmlText text1 = doc.CreateTextNode(newOrder.Cryptocurrency);
            element1.AppendChild(element2);
            element2.AppendChild(text1);

            XmlElement element3 = doc.CreateElement(string.Empty, "Price", string.Empty);
            XmlText text2 = doc.CreateTextNode(newOrder.Price.ToString());
            element3.AppendChild(text2);
            element1.AppendChild(element3);

            XmlElement element4 = doc.CreateElement(string.Empty, "Amount", string.Empty);
            XmlText text3 = doc.CreateTextNode(newOrder.Amount.ToString());
            element4.AppendChild(text3);
            element1.AppendChild(element4);


            MemoryStream data = new MemoryStream();
            doc.Save(data);
            byte[] dataForRequest = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(data.ToArray()));


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:46809/api/orders/rng");
            return sendRequest(dataForRequest, webRequest);
        }


        private static bool sendRequest(byte[] dataForRequest, HttpWebRequest webRequest)
        {
            webRequest.Method = "POST";
            webRequest.Accept = "application/xml";
            webRequest.ContentType = "application/xml";
            Stream requestData = webRequest.GetRequestStream();
            requestData.Write(dataForRequest, 0, dataForRequest.Length);
            requestData.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                Stream responseData = response.GetResponseStream();

                if (response.StatusCode.ToString().Equals("OK"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }



        internal static XmlElement SoapSearch(string keyword)
        {
            CoinsService.CryptoServiceSoapClient servis = new CoinsService.CryptoServiceSoapClient(CoinsService.CryptoServiceSoapClient.EndpointConfiguration.CryptoServiceSoap);
            CoinsService.SearchResponse result = servis.SearchAsync(keyword).Result;
            CoinsService.SearchResponseBody body = result.Body;
            XmlElement searchResult = body.SearchResult;

            return searchResult;
        }
    }
}
