using System;
using Xamarin.Forms;

namespace AaronsDayStarter.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Stage { get; set; }
        public string Day { get; set; }
        public FormattedString Content { get; set; }
    }
}