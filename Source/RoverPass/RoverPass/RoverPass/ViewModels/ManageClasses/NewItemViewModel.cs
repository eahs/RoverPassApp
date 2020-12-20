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
        private string teacher;
        private string block;
        private string className;
        //private string text;
        

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(teacher)
                && !String.IsNullOrWhiteSpace(block)
                && !String.IsNullOrWhiteSpace(className);
        }

        
        public string Teacher
        {
            get => teacher;
            set => SetProperty(ref teacher, value);
        }
        public string Block
        {
            get => block;
            set => SetProperty(ref block, value);
        }
        public string ClassName
        {
            get => className;
            set => SetProperty(ref className, value);
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
                Teacher = Teacher,
                Block = Block,
                ClassName = ClassName
                
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
