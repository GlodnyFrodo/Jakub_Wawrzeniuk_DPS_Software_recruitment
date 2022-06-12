using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jakub_Wawrzeniuk_DPS_Software_recruitment
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        public delegate void delPassData(TextBox productName, TextBox price, TextBox amount);

        public string ProductNameValue  
        {
            get
            {
                return productNameTextBox.Text;
            }
        }

        public string PriceValue
        {
            get
            {
                return priceTextBox.Text;
            }
        }

        public string AmountValue
        {
            get
            {
                return amountTextBox.Text;
            }
        }

    }
}
