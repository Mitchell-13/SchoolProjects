using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOLinqEntity
{
    public partial class AddProductForm : Form
    {
        MyProductsDB db = new MyProductsDB();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // create a linq query to grab all the categories from the data
            // source. this is similar to the queries used in the category form
            // linq query in query format
            var categoryItems = (from item in db.Products
                                 where item.Category != null
                                 group item.Category by item.Category into singleCategory
                                 select new { Category = singleCategory.Key });
            // add the categories to the combobox
            CBCategory.Items.AddRange(categoryItems.Select(x => x.Category).ToArray());

            // provide an option to add a new category
            CBCategory.Items.Add("New Category");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal price = 0m;
            int uoh = 0;
            string cat = "";
            // validate the textboxes
            if (TxtBoxDesc.Text != "" && decimal.TryParse(TxtBoxPrice.Text, out price)
            && int.TryParse(TxtBoxUOH.Text, out uoh)
            && TxtBoxProd.Text.Length <= 5
            && TxtBoxProd.Text != "")
            {
                // check if a category is selected in the combobox
                if (CBCategory.SelectedIndex > -1)
                {
                    // check if a new category is selected
                    if (CBCategory.SelectedItem.ToString() != "New Category")
                    {
                        // grab the selected category
                        cat = CBCategory.SelectedItem.ToString();
                    }
                    else if (TxtBoxNew.Text != "")
                    {
                        // assign the new category to the cat variable
                        cat = TxtBoxNew.Text;
                    }
                    else
                    {
                        MessageBox.Show("Enter a category for the new category.");
                        TxtBoxNew.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Select a category");
                    TxtBoxNew.Focus();
                }
            }

            // assuming that the cat variable does NOT equal ""
            if (cat != "")
            {
                // add the user's input as a new product
                // since all the checks have passed
                db.Products.Add(new Product
                {
                    Product_Number = TxtBoxProd.Text,
                    Description = TxtBoxDesc.Text,
                    Category = cat,
                    Price = price,
                    Units_On_Hand = uoh
                });

                db.SaveChanges();

                Close();
            }
            else
            {
                MessageBox.Show("Please enter the correct values for the textboxes.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CBCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the user wants to add a new category, show the textbox and
            // label for the new category input
            if (CBCategory.SelectedItem.ToString() == "New Category")
            {
                TxtBoxNew.Show();
                lblNew.Show();
            }
            // otherwise, hide the label and textbox
            else
            {
                TxtBoxNew.Hide();
                lblNew.Hide();
            }
        }
    }
}
