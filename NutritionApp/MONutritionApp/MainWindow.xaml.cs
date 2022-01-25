using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace MONutritionApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Food> foodDict = new Dictionary<string, Food>();
        public MainWindow()
        {
            InitializeComponent();

            LoadFoodDetails();
        }
        /// <summary>
        /// load the file and add them to combobox
        /// </summary>
        private void LoadFoodDetails()
        {
            string fileName = "nutrition.txt";

            StreamReader inputFile;

            string[] currentFood;

            try
            {
                inputFile = File.OpenText(fileName);

                while (!inputFile.EndOfStream)
                {
                    currentFood = inputFile.ReadLine().Split('\t');
                    //put current line into the array
                    Food tempFood = new Food(currentFood);
                    //add to dictionary
                    foodDict.Add(tempFood.foodName, tempFood);
                    //add to box
                    CbFood.Items.Add(tempFood.foodName);

                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        /// <summary>
        /// display food details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFoodDetails_Click(object sender, RoutedEventArgs e)
        {
            //check if user selected anything
            if (CbFood.SelectedIndex > -1)
            {
                string selectedFood = CbFood.SelectedItem.ToString();
                //check if selected item is in dictionary
                if (foodDict.TryGetValue(selectedFood, out Food tempFood))
                {
                    //display details in new window
                    FoodDetails details = new FoodDetails(tempFood);
                    details.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Could not find the selected phone");
                }
            }
            else
            {
                MessageBox.Show("Please select a food");
            }
        }
    }
}
