using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AaronsDayStarter.Models;

namespace AaronsDayStarter.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Day = "Monday",
                    Content ="My Lord God, I have no idea where I am going. I do not see the road ahead of me. I cannot know for certain" +
                "where it will end. Nor do I really know myself, and the fact that I think I am following your will does mean that I am actually doing so." +
                "But I believe that the desire to please you does, in fact, please you. And I hope I have that desire in all that I am doing. I hope that I will" +
                "never do anything apart from your desire. And I know that, if I do this, You wil lead me by the right road, though I may know nothing about it. " +
                "Therefor I will trust you always though I may seem lost and in the shadow of death. I will not fear, for you are ever with me, and you never" +
                "leave me to face my perils alone. (Thomas Merton)" },
                new Item { Id = Guid.NewGuid().ToString(), Day = "Tuesday",
                    Content ="Soul of Christ, annctify me, Body of Christ, save me. Blod of Christ, inebriate me. Water form the side of Christ wash me." +
                    "Passion of Christ, strengthen me. O Good Jesus, hear me. Within your sounds hide me. Permit me not to seperate from you. From the wicked foe, defend me." +
                    "At the hour of my death, call and bid me come to you. That with your saints I may praise you for ever and ever." },
                new Item { Id = Guid.NewGuid().ToString(), Day = "Wednesday",
                    Content ="Deliver me, O Jesus:\n" +
                    "From the desire to be esteemed;\nFrom the desire of being honoured \nFrom the desire of being praised; \n" +
                    "From the desire of being preffered to others; \nFrom the desire of being consulted;\n" +
                    "From the desire of being approved;\n" +
                    "From the desire of being popular.\n\n" +
                    "Deliver me, O Jesus:\n" +
                    "From the fear of being humiliated: \nFrom the fear of being dispised: \nFrom the fear of being rebuked:\n" +
                    "From the fead of being slandered;\nFrom the fear of being forgotten;\nFrom the fear of being wronged;\n" +
                    "From the fear of being treated unfairly;\nFrom the fear of being suspected.\n\n" +
                    "And Jesus, grant me the grace:\n" +
                    "To desire that others might be more loved than I;\nThat oters might be more esteemed than i;\n" +
                    "That in the opinion of the world, otheres may increase and I decrease;\nThat others may be chosen and I set aside;\nThat others may be preferred to me in everything;\n" +
                    "That others may become holier than I, provided that I, too, become as holy as you want me to be. (Mother Teresa)" +
                "" },
                new Item { Id = Guid.NewGuid().ToString(), Day = "Thursday", Content="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Day = "Friday", Content="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Day = "Saturday", Content="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Day = "Sunday", Content="This is an item description." },
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