using Newtonsoft.Json;
using RestSharp;
using RoverPass.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model = RoverPass.Models.ClassesPage;

namespace RoverPass.ViewModels.ClassesPage
{
    /// <summary>
    /// ViewModel for My Article page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class ClassesPageViewModel : BaseViewModel
    {

        public ObservableCollection<Class> Classes { get; set; }
        public ICommand ButtonTapped { private set; get; }

        public ClassesPageViewModel ()
        {
          
            
            Classes = new ObservableCollection<Class>();

            Period p = new Period
            {
                PeriodId = 1,
                Name = "1(1-2)"
            };
            Classes.Add(new Class
            {
                ClassName = "Calculus"
            });
            Classes.Add(new Class
            {
                ClassName = "ADS"
            });
            Classes.Add(new Class
            {
                ClassName = "Accounting"
            });
            Classes.Add(new Class
            {
                ClassName = "English"
            });
            Classes.Add(new Class
            {
                ClassName = "Gym"
            });
            Classes.Add(new Class
            {
                ClassName = "Chemistry"
            });
            Classes.Add(new Class
            {
                ClassName = "Advisory"
            });
            Classes.Add(new Class
            {
                ClassName = "Add a new Class"
            });

            ButtonTapped = new Command(HandleButton);
        }

        private async void HandleButton(object obj)
        {
            Class c = obj as Class;

            // c is the class they clicked on
            await Shell.Current.GoToAsync("DestinationPage");
        }


    }

}
