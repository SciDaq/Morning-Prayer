using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AaronsDayStarter.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.24-7prayer.com/signup/e79c55?fbclid=IwAR0Pp0WHbjyaKt6FHPN9wURZjRchVbzPB2q9nxbk4jg0QyhmzTWFyi8eLwg")));
        }

        public ICommand OpenWebCommand { get; }
    }
}