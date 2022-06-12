using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    [Serializable]
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public double Amount { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public Product(string productName, decimal price, double amount)
        {
            ProductName = productName;
            Price = price;
            Amount = amount;
        }

        private static void Serialize(Product[] products, string filename)
        {
            FileStream fs = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Entities.Product));

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
