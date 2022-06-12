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

        private void ButtonEnable()
        {
            this.deleteProductButton.Enabled = (this.displayProductsListView.Items.Count > 0);
            this.modifyProductButton.Enabled = (this.displayProductsListView.Items.Count > 0);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            using(AddProductForm form = new AddProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string[] row = {form.PriceValue, form.AmountValue};

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
                            eachItem.SubItems[1].Text = form.PriceToModify;
                            eachItem.SubItems[2].Text = form.AmountToModify;

                        }
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            displayProductsListView.View = View.Details;
            ButtonEnable();
            displayProductsListView.LabelEdit = true;
        }

    }
}
