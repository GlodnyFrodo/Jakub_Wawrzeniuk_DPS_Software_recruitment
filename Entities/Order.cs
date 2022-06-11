using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    internal class Order
    {

        public int OrderId { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
