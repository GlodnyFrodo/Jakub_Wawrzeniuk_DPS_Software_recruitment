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
    public partial class SaveToXmlForm : Form
    {
        public SaveToXmlForm()
        {
            InitializeComponent();
        }
        public string FilenameForProduct
        {
            get
            {
                return filenameForProductsTextBox.Text;
            }
        }
        public string FilenameForOrder
        {
            get
            {
                return filenameForOrderTextBox.Text;
            }
        }

    }
}
