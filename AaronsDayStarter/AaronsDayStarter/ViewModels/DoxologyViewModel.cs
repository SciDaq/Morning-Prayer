using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AaronsDayStarter.ViewModels
{
    public class ThanksgivingViewModel : BaseViewModel
    {
        public ThanksgivingViewModel()
        {
            Title = "Thanksgiving";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}