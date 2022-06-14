using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    [XmlRoot("OrderInfo")]
    public class Order
    {
        [XmlAttribute ("OrderID")]
        public uint Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }
        [XmlArray("Products")]
        [XmlArrayItem("ProductReading")]
        public virtual Product[] Products { get; set; }

        public Order(uint OrderId, string name, string surname, DateTime dateOfBirth, Product[] products)
        {
            this.Id = OrderId;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Products = products;
        }
        public Order()
        {

        }

        public static void Serialize(Order order, string filename)
        {
            FileStream fs = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Entities.Order));

            try
            {
                fs = new FileStream(filename, FileMode.Create);
                serializer.Serialize(fs, order);
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
