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
    public partial class CategoryForm : Form
    {
        MyProductsDB db = new MyProductsDB();
        public CategoryForm()
        {
            InitializeComponent();
            LVCategory.Columns.Add("Category");
            LVCategory.Columns.Add("Total Count");
        }
        //close the page
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// show the number of items per category in a list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            
            List<CategoryTotal> categoryList = (from item in db.Products
                                                group item.Category by item.Category
                                                into singleCategory
                                                select new CategoryTotal
                                                {
                                                    Category = singleCategory.Key,
                                                    Total = singleCategory.Count()
                                                }).ToList();
            foreach (CategoryTotal item in categoryList)
            {
                //grab the data stored in the categoryList and convert to a single array
                string[] listItems = { item.Category,
                item.Total.ToString() };

                ListViewItem lvi = new ListViewItem(listItems);

                LVCategory.Items.Add(lvi);
            }
        }
    }
}
