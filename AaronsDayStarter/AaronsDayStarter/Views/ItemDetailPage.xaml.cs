using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AaronsDayStarter.Models;
using AaronsDayStarter.ViewModels;

namespace AaronsDayStarter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Day = "Item 1",
                Content = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BiblePage(new BiblePageViewModel()));
        }
    }
}