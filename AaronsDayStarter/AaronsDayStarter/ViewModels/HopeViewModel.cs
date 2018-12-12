using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AaronsDayStarter.ViewModels
{
    public class HopeViewModel : BaseViewModel
    {
        public HopeViewModel()
        {
            Title = "Prayer - Hope";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}