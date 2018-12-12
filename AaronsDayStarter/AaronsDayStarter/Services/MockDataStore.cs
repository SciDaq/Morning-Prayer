using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AaronsDayStarter.Models;
using Xamarin.Forms;

namespace AaronsDayStarter.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;
        public MockDataStore()
        {

            items = new List<Item>();

            var opening = new FormattedString();
            opening.Spans.Add(new Span { Text = "O Lord, Let my soul rise up to meet the morning ", FontAttributes = FontAttributes.None });
            opening.Spans.Add(new Span { Text = "as the day rises to meet the sun.\n\n", FontAttributes = FontAttributes.Bold });
            opening.Spans.Add(new Span { Text = "Glory to the Father, and to the son, and to the Holy Spirit, as it was in the beginning is now and will be for ever\n\n", FontAttributes = FontAttributes.Bold });
            opening.Spans.Add(new Span { Text = "Come; let us sing to the lord: Let us shout to the Rock of our salvation", FontAttributes = FontAttributes.None });
            var dailyMonday = new FormattedString();
            dailyMonday.Spans.Add(new Span
            {
                Text = "My Lord God, I have no idea where I am going. \nI do not see the road ahead of me. \n\n" +
                    "I cannot know for certain where it will end. \n\n" +
                    "Nor do I really know myself, and the fact that I think I am following your will does mean that I am actually doing so.\n\n" +
                    "But I believe that the desire to please you does, in fact, please you. \n\n" +
                    "And I hope I have that desire in all that I am doing. I hope that I will never do anything apart from your desire. \n\n" +
                    "And I know that, if I do this, You wil lead me by the right road, though I may know nothing about it. \n\n" +
                    "Therefor I will trust you always though I may seem lost and in the shadow of death. \n\n" +
                    "I will not fear, for you are ever with me, and you never leave me to face my perils alone. (Thomas Merton)",
                FontAttributes = FontAttributes.None
            });
            var dailyTuesday = new FormattedString();
            dailyTuesday.Spans.Add(new Span
            {
                Text = "Soul of Christ, annctify me, Body of Christ, save me. \n\n" +
                    "Blood of Christ, inebriate me. Water form the side of Christ wash me." +
                    "Passion of Christ, strengthen me. O Good Jesus, hear me. \n\n" +
                    "Within your sounds hide me. \n\n" +
                    "Permit me not to seperate from you. From the wicked foe, defend me." +
                    "At the hour of my death, call and bid me come to you. \n\n" +
                    "That with your saints I may praise you for ever and ever.",
                FontAttributes = FontAttributes.None
            });
            var mockItems = new List<Item>
            {
            new Item {Id = Guid.NewGuid().ToString(), Stage="Opening", Day="Every",
                    Content = opening },
                new Item {Id = Guid.NewGuid().ToString(), Stage="Old Testament", Day="Every", Content="Old Testament Reading"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="Thanksgiving", Day="Every", Content="Prayers of Thanksgiving"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="Psalms", Day="Every", Content="Read a passage from the Psalms"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="Prayers Hope", Day="Every", Content="Prayers of Hope for the day"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="New Testament", Day="Every", Content="New Testament reading"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="Silence", Day="Every", Content="Take a minute to consider the reading in silence"},
                new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Monday", Content = dailyMonday },
                new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Tuesday",  Content = dailyTuesday               },
                new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Wednesday",
                    Content ="I am no longer my own but thine:\n\n" +
                    "Put me to what thou will, rank me wth whom thou will.\n\n" +
                    "Put me to doing, put me to sufferning.\n\n" +
                    "Let me be employed by thee or laid asidde for thee, exalted for thee or brought low for thee.\n\n" +
                    "Let me be full, let me be empty. \n\n" +
                    "Le me have all things, let me have nothing.\n\n" +
                    "I freely and hearily yeald all things to thy pleasure and disposal.\n\n" +
                    "And now, O glorious and blessed God, Father, Son and Holy Spirit, thout art mine, and I am thine.\n\n" +
                    "So be it.\n\n" +
                    "And the covenant I have made on earth, let it be ratified in heaven. Amen (John Wesley)"
                    },
                new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Thursday",
                    Content ="Deliver me, O Jesus:\n\n" +
                    "From the desire to be esteemed;\n\n" +
                    "From the desire of being honoured \n\n" +
                    "From the desire of being praised; \n\n" +
                    "From the desire of being preffered to others; \n\n" +
                    "From the desire of being consulted;\n\n" +
                    "From the desire of being approved;\n\n" +
                    "From the desire of being popular.\n\n\n" +
                    "Deliver me, O Jesus:\n\n" +
                    "From the fear of being humiliated: \n\n" +
                    "From the fear of being dispised: \n\n" +
                    "From the fear of being rebuked:\n\n" +
                    "From the fead of being slandered;\n\n" +
                    "From the fear of being forgotten;\n\n" +
                    "From the fear of being wronged;\n\n" +
                    "From the fear of being treated unfairly;\n\n" +
                    "From the fear of being suspected.\n\n\n" +
                    "And Jesus, grant me the grace:\n\n" +
                    "To desire that others might be more loved than I;\n\n" +
                    "That oters might be more esteemed than i;\n\n" +
                    "That in the opinion of the world, otheres may increase and I decrease;\n\n" +
                    "That others may be chosen and I set aside;\n\n" +
                    "That others may be preferred to me in everything;\n\n" +
                    "That others may become holier than I, provided that I, too, become as holy as you want me to be. (Mother Teresa)" +
                "" },
                new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Friday", Content="To Be Added." },
                //new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Saturday", Content="To Be Added." },
                //new Item { Id = Guid.NewGuid().ToString(), Stage="Daily Prayer", Day = "Sunday", Content="To Be Added." },
                new Item {Id = Guid.NewGuid().ToString(), Stage="Others", Day="Every", Content="Prayers for other people"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="The Lords Prayer", Day="Every",
                    Content ="Our Father who art in heaven, hallowed be thy name.\n\n" +
                                "Thy kingdom come. Thy will be done, on earth as it is in heaven.\n\n" +
                                "Give us this day our daily bread;\n\n" +
                                "and forgive us our trespasses, as we forgive those who trespass against us;\n\n" +
                                "and lead us not into temptation, but deliver us from evil.\n\n" +
                                "For yours is the Kingdom, the power and the Glory.\n\n"},
                new Item {Id = Guid.NewGuid().ToString(), Stage="Doxology", Day="Every",
                    Content ="Praise God from whom all belssings flow\n\n" +
                    "Praise Him all creatures here below\n\n" +
                    "Priase Him above ye heavenly Hosts\n\n" +
                    "Praise Father, Son and Holy Gost."},
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}