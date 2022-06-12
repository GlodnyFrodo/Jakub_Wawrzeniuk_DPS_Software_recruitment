using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    internal class Order
    {
        public uint OrderId { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual Product[] Products { get; set; }

        public Order(string name, string surname, DateTime dateOfBirth, Product[] products)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Products = products;
        }
    }
}
