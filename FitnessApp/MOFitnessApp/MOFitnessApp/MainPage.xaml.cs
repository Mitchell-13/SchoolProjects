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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MOFitnessApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // runs code when the page is loaded
            InitializeComponent();
            //Changes date lable to todays date
            LblDate.Text = DateTime.Now.ToString("d");
        }
        /// <summary>
        /// Button to navigate to BMR Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBMRPpage_Clicked(object sender, EventArgs e)
        {
            //Navigate to BMR Page
            Navigation.PushAsync(new MyBMRPage());
        }
        /// <summary>
        /// Button to navigate to my profile page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMyProfilePage_Clicked(object sender, EventArgs e)
        {
            // Navigate to MyProfilePage
            Navigation.PushModalAsync(new MyProfilePage());
        }
        /// <summary>
        /// Button to navigate to timer page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTimer_Clicked(object sender, EventArgs e)
        {
            //navigate to timer page
            Navigation.PushAsync(new MyTimerPage());
        }

        private void BtnMyWater_Clicked(object sender, EventArgs e)
        {
            //navigate to water page
            Navigation.PushAsync(new MyWaterPage());
        }

        private void BtnFoodItem_Clicked(object sender, EventArgs e)
        {
            //navigate to food page
            Navigation.PushAsync(new FoodDetails());
        }
    }
}

