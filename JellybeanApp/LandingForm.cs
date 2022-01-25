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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// show category form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCat_Click(object sender, EventArgs e)
        {
            JellyBeanCatForm jellyBeanCatForm = new JellyBeanCatForm();
            jellyBeanCatForm.ShowDialog();
        }
        /// <summary>
        /// show search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            JellyBeanSearchForm jellyBeanSearchForm = new JellyBeanSearchForm();
            jellyBeanSearchForm.ShowDialog();
        }
    }
}
