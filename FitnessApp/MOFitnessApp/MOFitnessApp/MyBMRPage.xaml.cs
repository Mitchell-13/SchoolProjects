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
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOFitnessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyBMRPage : ContentPage
    {
        const int F_BMR1 = 655 ;
        const double F_BMR2 = 4.35;
        const double F_BMR3 = 4.7;
        const double M_BMR1 = 66;
        const double M_BMR2 = 6.23;
        const double M_BMR3 = 12.7;
        const double M_BMR4 = 6.8;
        const double LITTLE = 1.2;
        const double LIGHT = 1.375;
        const double MODERATE = 1.55;
        const double HEAVY = 1.725;
        const double INTENSE = 1.9;
        public MyBMRPage()
        {
            InitializeComponent();
            PckActivity.SelectedIndex = 1;
            PckGender.SelectedIndex = 0;
        }
        /// <summary>
        /// Button to calculate BMR based on user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCalculate_Clicked(object sender, EventArgs e)
        {
            //Declare variables
            double MaleBMR;
            double FemaleBMR;
            double multiplier = 0;
            //Show profile page as Modal
            var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
            var modalPage = new MyProfilePage();
            modalPage.Disappearing += (sender2, e2) =>
            {
                waitHandle.Set();
            };
            await Navigation.PushModalAsync(modalPage);
            await Task.Run(() => waitHandle.WaitOne());
            //Chech user input for activity level
            switch (PckActivity.SelectedItem.ToString())
            {
                //Set multiplier variable depending on user input
                case "Very Light Activity":
                    multiplier = LITTLE;
                    break;
                case "Light Activity":
                    multiplier = LIGHT;
                    break;
                case "Moderate Activity":
                    multiplier = MODERATE;
                    break;
                case "Heavy Activity":
                    multiplier = HEAVY;
                    break;
                case "Very Heavy Activity":
                    multiplier = INTENSE;
                    break;
            }
            //Check user input for gender
            if (PckGender.SelectedItem.ToString() == "Male")
            {
                //Run thsi if Male is entered in and display result
               MaleBMR = (M_BMR1 + (M_BMR2 * FitnessGlobalVariables.ProfWeight) + (M_BMR3 * FitnessGlobalVariables.ProfHeight) - (M_BMR4 * FitnessGlobalVariables.ProfAge)) * multiplier;
                lblResults.Text = MaleBMR.ToString("n2");
            }
            else
            {
                //Run this code if Female is entered in and display result
                FemaleBMR = (F_BMR1 + (F_BMR2 * FitnessGlobalVariables.ProfWeight) + (F_BMR3 * FitnessGlobalVariables.ProfHeight) - (F_BMR3 * FitnessGlobalVariables.ProfAge)) * multiplier;
                lblResults.Text = FemaleBMR.ToString("n2");
            }
        }
        /// <summary>
        /// Button to navigate back to the main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Clicked(object sender, EventArgs e)
        {
            //navigate back to main page
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}