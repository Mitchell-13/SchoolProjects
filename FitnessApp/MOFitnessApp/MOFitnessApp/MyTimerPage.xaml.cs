//Name: (Mitchell Ogden)
//Class: (INFO 1200)
//Section: (X02)
//Professor: (Crandall)
//Date: (4/8/2021)
//Project #:(7)
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
    public partial class MyTimerPage : ContentPage
    {
        //declare global variables
        int SECONDS = 60;
        int DOUBLE_DIGITS = 10;
        
        public MyTimerPage()
        {
            InitializeComponent();
        }
        int lapCount = 1;
        //start timer with delay
        private async Task StartTimer()
        {
            //give delay to equal 1 second
            await Task.Delay(1000);
        }
        /// <summary>
        /// button to start timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnStart_Clicked(object sender, EventArgs e)
        {
            //declare variable and set to empty string
            string direction = "";
            //validate user input
            if (GetDirection(ref direction))
            {
                //check which direction was entered
                if (direction == "Down")
                {
                    //call the count down method
                    var task = CountDown();
                    await task;
                }
                else
                {
                    //call the count up method 
                    var task = CountUp();
                    await task;
                }
            }
            ;
                    
        }
        /// <summary>
        /// make the clock count down
        /// </summary>
        /// <returns></returns>
        private async Task CountDown()
        {
            //declare variables
            int userEntry;
            //validate user entry
            if (int.TryParse(EntryTime.Text, out userEntry))
            {
                //hide button
                BtnStart.IsEnabled = false;
                //while loop to run while clock is still going
                while (userEntry >= 0)
                {
                    DisplayTime(userEntry);
                    // calls the starttimer async method
                    var task = StartTimer();
                    //await until the task is completed
                    await task;
                    
                    //subtract one from the time
                    userEntry--;
                }
                //show button again
                BtnStart.IsEnabled = true;
            }
            else
            {
                //display alert if input is invalid
                await DisplayAlert("Invalid Input", "Please enter an integer for time", "Close");
            }
        }
        /// <summary>
        /// displays the time on the clock
        /// </summary>
        /// <param name="time"></param>
        private void DisplayTime(int time)
        {
            //declare variables
            int minutes, seconds, userEntry;
            //set userentry and time = to eachother
            userEntry = time;
            //calculate seconds and minutes
            minutes = userEntry / SECONDS;
            seconds = userEntry % SECONDS;
            //display time on clock
            LblTimer.Text = $"{minutes:00}:{seconds:00}";
        }
        /// <summary>
        /// Make the timer count up
        /// </summary>
        /// <returns></returns>
        private async Task CountUp()
        {
            //declare variables
            int userEntry, time;
            //validate entry for time
            if (int.TryParse(EntryTime.Text, out time))
            {
                //set clock to 0
                userEntry = 0;
                //hide button
                BtnStart.IsEnabled = false;
                //while loop to run while clock is still going
                while (time >= userEntry)
                {
                    DisplayTime(userEntry);
                    // calls the starttimer async method
                    var task = StartTimer();
                    //await until the task is completed
                    await task;

                    //add 1 to userentry
                    userEntry++;
                }
                //show button again
                BtnStart.IsEnabled = true;
            }
            else
            {
                //display alert if input is invalid
                await DisplayAlert("Invalid Input", "Please enter an integer for time", "Close");
            }
        }
        /// <summary>
        /// validate and get entry for direction
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        private bool GetDirection(ref string direction)
        {
            //validate entry for direction
            if (PckDirection.SelectedIndex >=0)
            {
                //get user entry and return true
                direction = PckDirection.SelectedItem.ToString();
                return true;
            }
            else
            {
                //display alert for no entry and return false
                DisplayAlert("Invalid Input", "Please choose a direction", "Close");
                return false;
            }
        }
        /// <summary>
        /// close page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            //navigate back to the home page
            Navigation.PopAsync();
        }
        /// <summary>
        /// button to lap current time and display number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLap_Clicked(object sender, EventArgs e)
        {
            //variable for current time
            string time = LblTimer.Text;
            //Display lap number and current time
            LblLapResults.Text = LblLapResults.Text + $"[Lap#" +lapCount + ":"+ time +"]";
            lapCount ++;
        }
    }
}