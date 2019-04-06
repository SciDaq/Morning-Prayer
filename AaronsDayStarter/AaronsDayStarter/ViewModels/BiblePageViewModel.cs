using AaronsDayStarter.Models;
using AaronsDayStarter.Services;
using AaronsDayStarter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AaronsDayStarter.ViewModels
{
	public class BiblePageViewModel : BaseViewModel
	{

        public List<BibleBook> BibleBookList { get; set; } 
        public FormattedString BiblePassages { get; set; }
        public String PassageUrl { get; set; }
        public BibleBook BibleBookSelected { get; set; }
        public List<String> ChapterList { get; set; }
        public String ChapterFrom { get; set; }
        public String ChapterTo { get; set; }

        public Command FindPassage { get; set; }

        public BiblePageViewModel()
        {
            StartPage(new Item());
        }

        public BiblePageViewModel(Item item)
        {
            StartPage(item);
        }

        private void StartPage(Item item)
        {
            if (item != null)
            {
                if (item.Stage == "Old Testament")
                    BibleBookList = BibleBooks.Books.Where(t => t.Testament == "OT").ToList(); ;
                if (item.Stage == "New Testament")
                    BibleBookList = BibleBooks.Books.Where(t => t.Testament == "NT").ToList();
                if (item.Stage == "Psalms")
                    BibleBookList = BibleBooks.Books.Where(t => t.BibleSection == "Poetry").ToList();
            }
            else
            {
                BibleBookList = BibleBooks.Books;
            }
            OnPropertyChanged("BibleBookList");
            ChapterFrom = "0";
            ChapterTo = "0";
            OnPropertyChanged("ChapterFrom");
            OnPropertyChanged("ChapterTo");

            FindPassage = new Command(GetBiblePassage);

            MessagingCenter.Subscribe<BiblePage, BibleBook>(this, "SelectedBookChanged", (obj, value) =>
            {
                BibleBookSelected = (BibleBook)value;
                String book = value.Book;

                ChapterList = new List<String>();
                for (int a = 1; a <= BibleBookSelected.Chapters; a++)
                {
                    ChapterList.Add(a.ToString());
                }
                OnPropertyChanged("ChapterList");
            });

            MessagingCenter.Subscribe<BiblePage, String>(this, "SelectedChapterFromChanged", (obj, value) =>
            {
                ChapterFrom = value;
            });

            MessagingCenter.Subscribe<BiblePage, String>(this, "SelectedChapterToChanged", (obj, value) =>
            {
                ChapterTo = value;
            });
        }

        public void GetBiblePassage()
        {
            if (BibleBookSelected == null) return;
            if (ChapterFrom.Length == 0) return;
            if (ChapterTo.Length == 0) return;
            Int32 from = 0;
            Int32 to = 0;
            Int32.TryParse(ChapterFrom, out from);
            Int32.TryParse(ChapterTo, out to);
            String book = BibleBookSelected.Book;
            FormattedString result = APIInterface.GetPassage(book, from, 1, to, 20);
            //PassageUrl = APIInterface.GetPassageURL(book, 1, 1, 1, 16).AbsoluteUri;
            BiblePassages = result;
            OnPropertyChanged("BiblePassages");
            OnPropertyChanged("PassageUrl");
        }

    }
}