using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AaronsDayStarter.ViewModels
{
    public class OpenViewModel : BaseViewModel
    {
        public OpenViewModel()
        {
            Title = "Opening";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}