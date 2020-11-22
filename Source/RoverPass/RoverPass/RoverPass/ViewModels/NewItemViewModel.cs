using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using RoverPass.Models;
using Xamarin.Forms;


namespace RoverPass.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string classCode;
        

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(classCode);
              
        }

        public string Text
        {
            get => classCode;
            set => SetProperty(ref classCode, value);
        }

        

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
