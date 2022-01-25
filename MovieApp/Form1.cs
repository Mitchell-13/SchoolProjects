using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOMovieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallDataSet);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200_CrandallDataSet.Movie);

        }
        /// <summary>
        /// sort by a-z
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSortAZ_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByAZ(this.iNFO2200_CrandallDataSet.Movie);
        }
        /// <summary>
        /// sort by z-a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSortZA_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByZA(this.iNFO2200_CrandallDataSet.Movie);
        }
        /// <summary>
        /// sort by category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCustom_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByRandom(this.iNFO2200_CrandallDataSet.Movie);
        }
        /// <summary>
        /// sort by text entyry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByTitle(this.iNFO2200_CrandallDataSet.Movie, TxtBoxSearch.Text);
        }
    }
}
