using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AaronsDayStarter.ViewModels
{
    public class SilenceViewModel : BaseViewModel
    {
        public SilenceViewModel()
        {
            Title = "Silence";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}