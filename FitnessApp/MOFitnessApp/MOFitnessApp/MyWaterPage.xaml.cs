//Name: (Mitchell Ogden)
//Class: (INFO 1200)
//Section: (X02)
//Professor: (Crandall)
//Date: (4/22/2021)
//Project #:(8)
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOFitnessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyWaterPage : ContentPage
    {
        //create global variable
        const int DAILY_WATER = 8;
        //create variables
        string today = DateTime.Now.ToString("d");
        string documents = "";
        string filename = "";
        string filestored = "";
        int watercount = 0;

        
        public MyWaterPage()
        {
            InitializeComponent();
            //get file path
            GetFilePath();
            //display today's date
            LblDate.Text = today;
        }
        /// <summary>
        /// get saved file
        /// </summary>
        private void GetFilePath()
        {
            //get file path
            documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //get file name
            filename = $"{today}water.txt";
            //combine file path and file name
            filestored = Path.Combine(documents, filename);
            // run this if a file already exists
            if (File.Exists(filestored))
            {
                //set variable to stored water count
                watercount = int.Parse(File.ReadAllLines(filestored).Last().ToString());
                //for loop to add images to gui
                for (int i = 0; i < watercount; i++)
                {
                    //create new image
                    Image image = new Image { Source = "Water.jpg" };
                    // add image to gui
                    SLWater.Children.Add(image);
                }
                //display water count
                LblWaterCount.Text = $"Water Count: {watercount}";

            }


        }
        /// <summary>
        /// button to add to water count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddWater_Clicked(object sender, EventArgs e)
        {
            //add water to counter
            AddWater();
            
        }
        /// <summary>
        /// add water to gui and save file
        /// </summary>
        private void AddWater()
        {
            //determine if daily water is less than 8
            if (watercount < DAILY_WATER)
            {
                //create new image
                Image image = new Image { Source = "Water.jpg" };
                //add image to gui
                SLWater.Children.Add(image);
                //increment water count
                watercount++;
                //display water count
                LblWaterCount.Text = $"Water Count: {watercount}";
                //save water count
                File.WriteAllText(filestored, watercount.ToString());

            }
            else
            {
                //display error message
                DisplayAlert("Error", "Maximum water count reached", "close");
            }
            
        }
        /// <summary>
        /// close page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            //Close Page
            Navigation.PopAsync();
        }
    }
}