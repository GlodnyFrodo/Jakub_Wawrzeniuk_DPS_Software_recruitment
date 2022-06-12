using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public double Amount { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
