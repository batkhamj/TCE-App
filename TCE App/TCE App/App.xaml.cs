using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TCE_App.Services;
using TCE_App.Views;

namespace TCE_App
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
