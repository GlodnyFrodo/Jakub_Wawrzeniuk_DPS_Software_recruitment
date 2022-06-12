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
    public partial class DeleteProductForm : Form
    {
        public DeleteProductForm()
        {
            InitializeComponent();
        }

        public string ProductNameToDelete
        {
            get
            {
                return productNameDeleteTextBox.Text;
            }
        }
    }
}
