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
    public partial class ModifyProductForm : Form
    {
        public ModifyProductForm()
        {
            InitializeComponent();
        }

        public string ProductNameToModify
        {
            get
            {
                return productNameTextBox.Text;
            }
        }

        public string PriceToModify
        {
            get
            {
                return priceTextBox.Text;
            }
        }

        public string AmountToModify
        {
            get
            {
                return amountTextBox.Text;
            }
        }
    }
}
