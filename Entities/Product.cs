using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    [XmlRoot("ProductInfo")]
    //internal
    public class Product
    {
        //[XmlRoot]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public double Amount { get; set; }
        [XmlIgnore]
        public int OrderId { get; set; }
        [XmlIgnore]
        public virtual Order Order { get; set; }

        public Product( int Id, string productName, decimal price, double amount)
        {
            this.Id = Id;
            ProductName = productName;
            Price = price;
            Amount = amount;
        }
        public Product( Product p, Order Order)
        {
            ProductName = p.ProductName;
            Price = p.Price;
            Amount = p.Amount;
            this.OrderId = Order.Id;
            this.Order = Order;
        }
        public Product(Product p)
        {
            ProductName = p.ProductName;
            Price = p.Price;
            Amount = p.Amount;
        }
        public Product() { }

        public static void Serialize(Product[] products, string filename)
        {
            FileStream fs = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Product[]));

                /*using (XmlWriter writer = XmlWriter.Create)
                {
                    serializer.Serialize(writer, products);
                }*/
            try
            {
                fs = new FileStream(filename, FileMode.Create);
                serializer.Serialize(fs, products);
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd! {0}", e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
