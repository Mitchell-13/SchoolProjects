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
    public partial class Products : Form
    {

        public Products()
        {
            InitializeComponent();
        }
        //Button to show the add product form
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
        // search through the products when the textbox changes
        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            MyProductsDB db = new MyProductsDB();
            List<Product> productList = (from prod in db.Products
                                         where prod.Description.Contains(TxtBoxSearch.Text)
                                         select prod).ToList();

            dataGridView1.DataSource = productList;

            AutoSizeColumns();
        }
        //Load all of the products onto the data grid view
        private void Products_Load(object sender, EventArgs e)
        {
            MyProductsDB db = new MyProductsDB();
            List<Product> productList = (from prod in db.Products
                                         select prod).ToList();

            dataGridView1.DataSource = productList;

            AutoSizeColumns();
        }
        /// <summary>
        /// method to autosize the columns to what is being displayed
        /// </summary>
        private void AutoSizeColumns()
        {
            int columns = dataGridView1.Columns.Count;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
