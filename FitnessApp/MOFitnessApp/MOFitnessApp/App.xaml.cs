using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOFitnessApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Landing Page
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
