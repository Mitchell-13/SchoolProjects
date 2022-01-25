//Name: (Mitchell Ogden)
//Class: (INFO 1200)
//Section: (X02)
//Professor: (Crandall)
//Date: (4/28/2021)
//Project #:(9)
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;


namespace MOFitnessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodDetails : ContentPage
    {
        List<FoodItem> FoodItems = new List<FoodItem>();
        List<string> FoodNames = new List<string>();
        public FoodDetails()
        {
            InitializeComponent();
            LoadFile();
        }

        private void LoadFile()
        {
            //access the solution explorer
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(FoodDetails)).Assembly;
            //find the file
            Stream stream = assembly.GetManifestResourceStream("MOFitnessApp.food.txt");
            //create array to store food items
            string[] foodItem;
            //new instance of stream reader
            using (var reader = new StreamReader(stream)) 
            {
                //skip the first line
                reader.ReadLine();
                //loop through all food items and add to list
                while (!reader.EndOfStream)
                {
                    foodItem = reader.ReadLine().Split('\t');
                    FoodItem food = new FoodItem(foodItem);
                    FoodNames.Add(food.FoodName);
                    FoodItems.Add(food);

                }
                //sort by alphabetical
                FoodNames.Sort();
                //add items to picker
                PckrFoodItems.ItemsSource = FoodNames;

            }
        }
        /// <summary>
        /// show details of chosen food item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetails_Clicked(object sender, EventArgs e)
        {
            //new instance of food item
            FoodItem selectedFood = new FoodItem();
            if (true)
            {
                //find food item that was selected in picker
                foreach (FoodItem food in FoodItems)
                {
                    if (food.FoodName == PckrFoodItems.SelectedItem.ToString())
                    {
                        selectedFood = food;
                    }
                }
                //display results
                DisplayAlert(selectedFood.FoodName, $"Category: {selectedFood.Category}\n\n" +
                  $"Measurement: {selectedFood.Measurement}\n\n" +
                  $"Calories: {selectedFood.Calories.ToString("n0")}", "Close");
            }
            else
            {
                //error message to pick an item
                DisplayAlert("Invalid input", "Please choose a food item", "Close");
            }
        }


    }
}
