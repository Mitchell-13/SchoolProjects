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
    public partial class JellyBeanSearchForm : Form
    {
        //connects to jelly bean data
        JellyBellyModel db = new JellyBellyModel();
        public JellyBeanSearchForm()
        {
            InitializeComponent();


        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// search database based on text entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<JellyBelly> jbList = (from jellybean in db.JellyBeans
                                       where jellybean.jellyBellyFlavor.Contains(TxtBoxSearch.Text)
                                       select jellybean).ToList();

            DgvJellyBeans.DataSource = jbList;

        }
        /// <summary>
        /// search database based on selected category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<JellyBelly> jbList = (from jellybean in db.JellyBeans
                                       where jellybean.category == CBCat.SelectedItem.ToString()
                                       select jellybean).ToList();

            DgvJellyBeans.DataSource = jbList;
        }
        /// <summary>
        /// close search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// code to run when form is loaded/ load in database and display it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JellyBeanSearchForm_Load(object sender, EventArgs e)
        {
            //show jelly beans
            List<JellyBelly> jbList = (from jellybean in db.JellyBeans
                                       select jellybean).ToList();

            DgvJellyBeans.DataSource = jbList;
            //add categories to combo box
            var categoryItems = (from jellybean in db.JellyBeans
                                 where jellybean.category != null
                                 group jellybean.category by jellybean.category into singleCategory
                                 select new { Category = singleCategory.Key });

            CBCat.Items.AddRange(categoryItems.Select(x => x.Category).ToArray());
        }
    }
}
