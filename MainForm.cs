using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        private void ErrorMessage()
        {
            string error = $"Błędne dane zamówienia";
            MessageBox.Show(error);
            ButtonEnable();
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
            this.saveToXmlButton.Enabled = (this.displayProductsListView.Items.Count > 0 && nameTextBox.Text != "" && surnameTextBox.Text != "" && dateOfBirthTextBox.Text != "");
            this.saveToDatabaseButton.Enabled = (this.displayProductsListView.Items.Count > 0 && nameTextBox.Text != "" && surnameTextBox.Text != "" && dateOfBirthTextBox.Text != "");
            this.modifyProductButton.Enabled = (this.displayProductsListView.Items.Count > 0);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            using (AddProductForm form = new AddProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    decimal price;
                    double amount;
                    if (Decimal.TryParse(form.PriceValue, out price) && Double.TryParse(form.AmountValue, out amount) && price > 0 && amount > 0 && form.ProductName != "")
                    {
                        string[] row = { form.AmountValue, form.PriceValue };

                        displayProductsListView.Items.Add(form.ProductNameValue).SubItems.AddRange(row);
                        ButtonEnable();
                    }
                    else
                    {
                        ErrorMessage();
                    }
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
                    decimal price;
                    double amount;
                    if (Decimal.TryParse(form.PriceToModify, out price) && Double.TryParse(form.AmountToModify, out amount) && price > 0 && amount > 0 && form.ProductName != "" )
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
                    else
                    {
                        ErrorMessage();
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
                Entities.Product p = new Entities.Product(id, eachItem.Text, Convert.ToDecimal(eachItem.SubItems[2].Text), Convert.ToDouble(eachItem.SubItems[1].Text));
                Array.Resize(ref selectedProducts, selectedProducts.Length + 1);
                selectedProducts[selectedProducts.Length - 1] = p;
                id++;
            }

            return selectedProducts;
        }
        int OrderId = 0;
        private Entities.Order CreateOrder()
        {
                Entities.Order order = new Entities.Order(OrderId, nameTextBox.Text, surnameTextBox.Text, Convert.ToDateTime(dateOfBirthTextBox.Text), CreateProducts().ToList());
                OrderId++;
                return order;
            }


        private static string filenameForProducts = "products.xml";
        private static string filenameForOrder = "order.xml";
        private void saveToXmlButton_Click(object sender, EventArgs e)
        {
            string folder = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                DateTime dateOfBirth;
                if (DateTime.TryParse(dateOfBirthTextBox.Text, out dateOfBirth) && nameTextBox.Text != "" && surnameTextBox.Text != "" && nameTextBox.Text.Length > 1 && surnameTextBox.Text.Length > 1)
                {


                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        folder = @"" + fbd.SelectedPath + @"\";
                        filenameForProducts = folder + "products.xml";
                        filenameForOrder = folder + "order.xml";

                        Entities.Product.Serialize(CreateProducts(), filenameForProducts);
                        Entities.Order.Serialize(CreateOrder(), filenameForOrder);
                        displayProductsListView.Items.Clear();
                        string message = $"Zapisano do XML";
                        MessageBox.Show(message);
                        displayProductsListView.View = View.Details;
                        surnameTextBox.Text = "";
                        dateOfBirthTextBox.Text = "";
                        ButtonEnable();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                }
                else
                {
                    ErrorMessage();
                }

            }




        }

        private void dateOfBirthTextBox_Enter(object sender, EventArgs e)
        {
            if (dateOfBirthTextBox.Text == "YYYY-MM-DD")
            {
                dateOfBirthTextBox.Text = "";
                dateOfBirthTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonEnable();
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonEnable();
        }

        private void dateOfBirthTextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonEnable();
        }

        private void saveToDatabaseButton_Click(object sender, EventArgs e)
        {

            using (var context = new Entities.OrdermanagementDbContext())
            {
                Entities.Order o1 = new Entities.Order(CreateOrder());
                List<Entities.Product> products = new List<Entities.Product>();
                foreach (Entities.Product p in CreateProducts())
                {
                    ;
                    Entities.Product p1 = new Entities.Product(p, o1.Id, o1);
                    context.Products.Add(p1);
                    products.Add(p1);
                    context.SaveChanges();

                }
                o1 = new Entities.Order(o1, products);
                context.Orders.Add(o1);
                context.SaveChanges();
            }
        }
    }
}

