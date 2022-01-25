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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// open the prducts form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
        }
        /// <summary>
        /// open the category form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm newCategoryForm = new CategoryForm();
            newCategoryForm.ShowDialog();
        }
    }
}
