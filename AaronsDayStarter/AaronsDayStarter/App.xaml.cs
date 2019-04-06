using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AaronsDayStarter.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AaronsDayStarter
{
    public partial class App : Application
    {
        public String BibleAppKey = "n4sie0lbmxRdmU26SQPGjIUaXZmPDuOlRL7Vg0F6";
        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
