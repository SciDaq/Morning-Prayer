using AaronsDayStarter.Services;
using AaronsDayStarter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AaronsDayStarter.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BiblePage : ContentPage
	{
        BiblePageViewModel viewModel;
		public BiblePage ()
		{
			InitializeComponent ();
		}


        public BiblePage(BiblePageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        private void BookSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker pkr = (Picker)sender;
            BibleBook book = (BibleBook)pkr.SelectedItem;
            MessagingCenter.Send(this, "SelectedBookChanged", book);
        }
        private void ChapterFromSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker pkr = (Picker)sender;
            String chapter = (String)pkr.SelectedItem;
            MessagingCenter.Send(this, "SelectedChapterFromChanged", chapter);
        }
        private void ChapterToSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker pkr = (Picker)sender;
            String chapter = (String)pkr.SelectedItem;
            MessagingCenter.Send(this, "SelectedChapterToChanged", chapter);
        }
    }
}