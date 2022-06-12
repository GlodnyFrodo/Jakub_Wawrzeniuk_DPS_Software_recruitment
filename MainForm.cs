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
    public partial class orderManagementSystemForm : Form
    {
        public orderManagementSystemForm()
        {
            InitializeComponent();
        }

 

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddProductForm(nameTextBox, surnameTextBox, dateOfBirthTextBox);
            newForm.Show();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            var newForm = new DeleteProductForm();
            newForm.Show();
        }

        private void changeProductButton_Click(object sender, EventArgs e)
        {
            var newForm = new ModifyProductForm();
            newForm.Show();
        }
    }
}
