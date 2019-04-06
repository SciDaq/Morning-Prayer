using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AaronsDayStarter.Models;
using AaronsDayStarter.Views;
using AaronsDayStarter.ViewModels;

namespace AaronsDayStarter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;
            if(item.Stage == "Old Testament")
                await Navigation.PushAsync(new BiblePage(new BiblePageViewModel(item)));
            else if (item.Stage == "Psalms")
                await Navigation.PushAsync(new BiblePage(new BiblePageViewModel(item)));
            else if (item.Stage == "New Testament")
                await Navigation.PushAsync(new BiblePage(new BiblePageViewModel(item)));
            else
                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}