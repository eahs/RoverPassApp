using System;
using System.Collections.ObjectModel;
using RoverPass.Models;
using RoverPass.Models.AddNewClass;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RoverPass.ViewModels.AddNewClass
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AddNewClassViewModel : BaseViewModel
    {
        private string classCode;

        //private string text;


        public AddNewClassViewModel()
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


        public string ClassCode
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
                ClassCode = ClassCode
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

    }
}