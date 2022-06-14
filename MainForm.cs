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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            displayProductsListView.View = View.Details;
            ButtonEnable();
            displayProductsListView.LabelEdit = true;
        }

        private void ButtonEnable()
        {
            this.deleteProductButton.Enabled = (this.displayProductsListView.Items.Count > 0);
            this.modifyProductButton.Enabled = (this.displayProductsListView.Items.Count > 0);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            using (AddProductForm form = new AddProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string[] row = { form.AmountValue, form.PriceValue};

                    displayProductsListView.Items.Add(form.ProductNameValue).SubItems.AddRange(row);
                    ButtonEnable();

                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            using (DeleteProductForm form = new DeleteProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem eachItem in displayProductsListView.Items)
                    {
                        if (eachItem.Text == form.ProductNameToDelete)
                        {
                            displayProductsListView.Items.Remove(eachItem);
                        }

                    }
                    ButtonEnable();

                }
            }
        }

        private void changeProductButton_Click(object sender, EventArgs e)
        {
            using (ModifyProductForm form = new ModifyProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem eachItem in displayProductsListView.Items)
                    {
                        if (eachItem.Text == form.ProductNameToModify)
                        {
                            eachItem.SubItems[2].Text = form.PriceToModify;
                            eachItem.SubItems[1].Text = form.AmountToModify;

                        }
                    }
                }
            }
        }
        
        private Entities.Product[] CreateProducts()
        {
            int id = 0;
            Entities.Product[] selectedProducts = new Entities.Product[0];
            foreach (ListViewItem eachItem in displayProductsListView.Items)
            {

                //string message = $"{eachItem.Text} {eachItem.SubItems[2].Text} {eachItem.SubItems[1].Text}";
                //MessageBox.Show(message);

                Entities.Product p = new Entities.Product(id, eachItem.Text, Convert.ToDecimal(eachItem.SubItems[2].Text), Convert.ToDouble(eachItem.SubItems[1].Text));
                Array.Resize(ref selectedProducts, selectedProducts.Length + 1);
                selectedProducts[selectedProducts.Length - 1] = p;
                id++;
            }

            return selectedProducts;
        }
        uint OrderId = 0;
        private Entities.Order CreateOrder()
        {
            
                Entities.Order order = new Entities.Order(OrderId, nameTextBox.Text, surnameTextBox.Text, Convert.ToDateTime(dateOfBirthTextBox.Text), CreateProducts());
                OrderId++;
                return order;
            }


        private static string filenameForProducts = "products.xml";
        private static string filenameForOrder = "order.xml";
        private void saveToXmlButton_Click(object sender, EventArgs e)
        {

            
            if (!String.IsNullOrEmpty(String.Concat(nameTextBox.Text.Where(c => !Char.IsWhiteSpace(c)))) && !String.IsNullOrEmpty(String.Concat(surnameTextBox.Text.Where(c => !Char.IsWhiteSpace(c)))) && !String.IsNullOrEmpty(String.Concat(dateOfBirthTextBox.Text.Where(c => !Char.IsWhiteSpace(c)))))
            {
                Entities.Product.Serialize(CreateProducts(), filenameForProducts);
                Entities.Order.Serialize(CreateOrder(), filenameForOrder);
                displayProductsListView.Clear();
                string message = $"Zapisano do XML";
                MessageBox.Show(message);
            }
            else
            {
                string error = $"Błędne dane zamówienia";
                MessageBox.Show(error);
            }
            
        }
    }
}

