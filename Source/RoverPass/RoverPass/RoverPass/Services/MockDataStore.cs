using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoverPass.Models;


namespace RoverPass.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), ClassName = "AP Lang", Teacher = "Mrs.Morgans", Block="First Block" },
                new Item { Id = Guid.NewGuid().ToString(), ClassName = "AP World",Teacher = "Mrs.Koser", Block="Second Block" },
                new Item { Id = Guid.NewGuid().ToString(), ClassName = "Advanced Data Structures",Teacher = "Mr.Tanczos", Block="Third Block" },
                new Item { Id = Guid.NewGuid().ToString(), ClassName = "Advisory", Teacher = "Mr.Tanczos",Block="Fourth Block" },
                new Item { Id = Guid.NewGuid().ToString(), ClassName = "Honors Chemistry",Teacher = "Mrs.Warner", Block="Fifth Block" },
                new Item { Id = Guid.NewGuid().ToString(), ClassName = "AP Calc BC",Teacher = "Mr.Wright", Block="Fifth Block" }
            };
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