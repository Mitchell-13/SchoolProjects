using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOJellybeanApp
{
    public partial class JellyBeanCatForm : Form
    {
        JellyBellyModel db = new JellyBellyModel();
        public JellyBeanCatForm()
        {
            InitializeComponent();

            LVCategory.Columns.Add("Flavors");
            LVCategory.Columns.Add("Category Count");
        }
        /// <summary>
        /// load form and organize into categories with their totals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JellyBeanCatForm_Load(object sender, EventArgs e)
        {
            List<JellyBellyCat> categoryList = (from item in db.JellyBeans
                                                group item.category by item.category
                                                into singleCategory
                                                select new JellyBellyCat
                                                {
                                                    Category = singleCategory.Key,
                                                    Total = singleCategory.Count()
                                                }).ToList();
            foreach (JellyBellyCat item in categoryList)
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
