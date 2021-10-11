using Crypto_Web_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Crypto_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public List<Order> Get()
        {
            return Startup.Orders;
        }

        private bool error = false;
        [HttpPost]
        public void Post(XmlElement xmlOrder)
        {
            try
            {
                XmlDocument doc = xmlOrder.OwnerDocument;
                doc.AppendChild(xmlOrder);
                doc.Schemas.Add("http://schemas.datacontract.org/2004/07/Crypto_Web_API.Models", "order.xsd");

                ValidationEventHandler validation = new ValidationEventHandler(XmlValidation);

                doc.Validate(XmlValidation);

                if (!error)
                {
                    DataContractSerializer deserializer = new DataContractSerializer(typeof(Order));
                    MemoryStream xmlStream = new MemoryStream();
                    doc.Save(xmlStream);
                    xmlStream.Position = 0;
                    Order newOrder = (Order)deserializer.ReadObject(xmlStream);
                    Startup.Orders.Add(newOrder);
                }
                else
                {
                    Response.StatusCode = StatusCodes.Status400BadRequest;
                }
            }
            catch
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        private void XmlValidation(object sender, ValidationEventArgs e)
        {
            error = true;
        }
    }
}
