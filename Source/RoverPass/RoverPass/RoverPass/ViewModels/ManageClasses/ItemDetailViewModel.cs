using System;
using System.Diagnostics;
using System.Threading.Tasks;
using RoverPass.Models;
using Xamarin.Forms;


namespace RoverPass.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string teacher;
        private string className;
        private string block;
        public string Id { get; set; }

        public string Teacher
        {
            get => teacher;
            set => SetProperty(ref teacher, value);
        }

        public string ClassName
        {
            get => className;
            set => SetProperty(ref className, value);
        }
        public string Block
        {
            get => block;
            set => SetProperty(ref block, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Teacher = item.Teacher;
                ClassName = item.ClassName;
                Block = item.Block;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
