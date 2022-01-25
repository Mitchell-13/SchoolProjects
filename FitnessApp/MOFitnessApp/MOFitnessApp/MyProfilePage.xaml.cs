//Name: (Mitchell Ogden)
//Class: (INFO 1200)
//Section: (X02)
//Professor: (Crandall)
//Date: (3/24/2021)
//Project #:(5)
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

namespace MOFitnessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyProfilePage : ContentPage
    {
        //Set constant variables
        const int MIN_WEIGHT = 50;
        const int MAX_WEIGHT = 1000;
        const int MIN_HEIGHT = 48;
        const int MAX_HEIGHT = 96;
        const int MIN_AGE = 12;
        const int MAX_AGE = 120;
        public MyProfilePage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// button to navigate back to main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            //declare variables
            double weight, height, age;

            //Validate user input for weight height and age
            if (double.TryParse(EntryWeight.Text, out weight) && weight <= MAX_WEIGHT && weight >= MIN_WEIGHT)
            {
                if (double.TryParse(EntryHeight.Text, out height) && height <= MAX_HEIGHT && height >= MIN_HEIGHT)
                {
                    if (double.TryParse(EntryAge.Text, out age) && age <= MAX_AGE && age >= MIN_AGE)
                    {
                        //set global variables
                        FitnessGlobalVariables.ProfAge = double.Parse(EntryAge.Text);
                        FitnessGlobalVariables.ProfHeight = double.Parse(EntryHeight.Text);
                        FitnessGlobalVariables.ProfWeight = double.Parse(EntryWeight.Text);
                        //navigate back to main page
                        Application.Current.MainPage.Navigation.PopModalAsync();
                    }
                    else
                    {
                        //display error message and reset age entry
                        DisplayAlert("Input Error", $"Please enter weight between {MIN_AGE} and {MAX_AGE}", "Close");
                        EntryAge.ClearValue(Entry.TextProperty);
                    }
                }
                else
                {
                    //display error message and reset height entry
                    DisplayAlert("Input Error", $"Please enter weight between {MIN_HEIGHT} and {MAX_HEIGHT}", "Close");
                    EntryHeight.ClearValue(Entry.TextProperty);
                }
            }
            else
            {
                //display error message and reset weight entry
                DisplayAlert("Input Error", $"Please enter weight between {MIN_WEIGHT} and {MAX_WEIGHT}", "Close");
                EntryWeight.ClearValue(Entry.TextProperty);

            }
        }
        /// <summary>
        /// Button to display before picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBefore_Clicked(object sender, EventArgs e)
        {
            // Changes image source to before picture
            ImgProfile.Source = "start.jpg";
        }
        /// <summary>
        /// Button to display after picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfter_Clicked(object sender, EventArgs e)
        {
            // changes image source to after picture
            ImgProfile.Source = "end.JPG";
            // Encouraging message when pushing after button
            DisplayAlert("Good Job", "You're doing great", "Close");
        }
        /// <summary>
        /// Button to clear user entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            //Clear all entries on the Profile page
            EntryAge.ClearValue(Entry.TextProperty);
            EntryHeight.ClearValue(Entry.TextProperty);
            EntryWeight.ClearValue(Entry.TextProperty);
            EntryLastName.ClearValue(Entry.TextProperty);
            EntryFirstName.ClearValue(Entry.TextProperty);
            EntryPrefName.ClearValue(Entry.TextProperty);
            //Set global variables equal to 0
            FitnessGlobalVariables.ProfAge = 0;
            FitnessGlobalVariables.ProfHeight = 0;
            FitnessGlobalVariables.ProfWeight = 0;
        }
    }
}