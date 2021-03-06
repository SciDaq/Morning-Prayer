﻿using System;

using AaronsDayStarter.Models;

namespace AaronsDayStarter.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Day;
            Item = item;
        }
    }
}
