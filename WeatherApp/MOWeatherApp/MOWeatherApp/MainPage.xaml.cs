using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MOWeatherApp
{
    public partial class MainPage : ContentPage
    {
        //Constant variable for the API key
        const string KEY = "e8540ba1374d09d4a029fc6be765be27";

        public MainPage()
        {
            InitializeComponent();
            LoadWeatherDetails("orem");
        }

        public void LoadWeatherDetails(string city)
        {
            //instantiate the WebClient class
            
            using (WebClient wc = new WebClient())
            {
                AllWeatherData allWeather = new AllWeatherData();
                //string to hold the JSON data
                string jsonData;
                try
                {
                    jsonData = wc.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={KEY}&units=imperial");
                    JObject parsedJson = JObject.Parse(jsonData);
                    //deserialize the json data into a custom class
                    AllWeatherData weatherData = JsonConvert.DeserializeObject<AllWeatherData>(jsonData);
                    LblCity.Text = parsedJson["name"].ToString();
                    LblTemp.Text = allWeather.main.temp.ToString();
                    LblWind.Text = $"Wind speed: {parsedJson["wind"]["speed"]} mph";
                    LblHighLow.Text = $"{Math.Round(weatherData.main.temp_max, 0)}°F\n" + $"{Math.Round(weatherData.main.temp_min, 0)}°F";
                    LblWeatherCondition.Text = weatherData.weather[0].main;
                    
                }
                catch (Exception ex)
                {
                    DisplayAlert("Oh no", $"{ex.Message}", "close");
                }
            }
        }

        private void BtnShowWeatherDetails_Clicked(object sender, EventArgs e)
        {
            if (EntCity.Text !=null)
            {
                LoadWeatherDetails(EntCity.Text);
            }
            else
            {
                DisplayAlert("Error", "Please enter a valid city", "Close");
            }
        }
    }
}
