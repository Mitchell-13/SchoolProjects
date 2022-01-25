using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;


namespace MOEarthquakeApp
{
    public partial class MainPage : ContentPage
    {
        Random rand = new Random();
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// connect to earthquake api and return earthquake details
        /// </summary>
        public void LoadEarthquakeDetails(string StartDate, string EndDate, int MinMag, int MaxMag)
        {
            //create webclient object that will connect to the API
            using (WebClient wc = new WebClient())
            {

                try
                {
                    string jsonData = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={StartDate}&endtime={EndDate}&minmagnitude={MinMag}&maxmagnitude={MaxMag}");

                    //JObject jsonBrackets = JObject.Parse(jsonData);
                    //lblResults.Text = jsonBrackets["features"][0]["properties"]["place"].ToString();

                    // use the created class to deserialize the JSON data into C# properties and classes
                    AllEarthquakeDetails allEarthquake = JsonConvert.DeserializeObject<AllEarthquakeDetails>(jsonData);

                    int earthquakeCount = allEarthquake.metadata.count;
                    int randomEarthquake = rand.Next(0, earthquakeCount);
                    

                    // assign the results label the location where the earthquake occurred
                    string randomPlace = allEarthquake.features[randomEarthquake].properties.place;
                    float randomMagnitude = allEarthquake.features[randomEarthquake].properties.mag;
                    DateTime time = UnixTimeStampToDateTime(allEarthquake.features[randomEarthquake].properties.time);

                    lblResults.Text = $"There were {earthquakeCount} earthquakes during this time.\n\n" +$"Details of one of them:\nPlace: {randomPlace}\nMagnitude: {randomMagnitude}";
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error",ex.Message, "Close");
                }
            }
        }
        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        /// <summary>
        /// gets user input and puts it into api request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked(object sender, EventArgs e)
        {
            //get user input
            string StartDate = pckStartDate.Date.ToString("yyyy-MM-dd");
            string EndDate = pckEndDate.Date.ToString("yyyy-MM-dd");
            int MinMag = int.Parse(PckMin.SelectedItem.ToString());
            int MaxMag = int.Parse(PckMax.SelectedItem.ToString());
            LoadEarthquakeDetails(StartDate, EndDate, MinMag, MaxMag);
        }
        private void BtnLargest_Clicked(object sender, EventArgs e)
        {
            //create webclient object that will connect to the API
            using (WebClient wc = new WebClient())
            {

                try
                {
                    string jsonData = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime=2019-01-01&minmagnitude=5&orderby=magnitude&limit=1");

                    AllEarthquakeDetails allEarthquake = JsonConvert.DeserializeObject<AllEarthquakeDetails>(jsonData);

                    // assign the results label the location where the earthquake occurred
                    string place = allEarthquake.features[0].properties.place;
                    float magnitude = allEarthquake.features[0].properties.mag;
                    lblResults.Text = $"The largest earthquake in the last 3 years occured {place} with a magnitude of {magnitude}";
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "Close");
                }
            }
        }

        private void BtnSmallest_Clicked(object sender, EventArgs e)
        {
            //create webclient object that will connect to the API
            using (WebClient wc = new WebClient())
            {

                try
                {
                    string jsonData = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime=2019-01-01&maxmagnitude=-1&orderby=magnitude-asc&limit=1");

                    AllEarthquakeDetails allEarthquake = JsonConvert.DeserializeObject<AllEarthquakeDetails>(jsonData);

                    // assign the results label the location where the earthquake occurred
                    string place = allEarthquake.features[0].properties.place;
                    float magnitude = allEarthquake.features[0].properties.mag;
                    lblResults.Text = $"The smallest earthquake in the last 3 years occured {place} with a magnitude of {magnitude}";
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "Close");
                }
            }
        }
    }
}
