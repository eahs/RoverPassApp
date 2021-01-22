using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using RoverPass.Models;
using RoverPass.Models.QueuePage;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RoverPass.ViewModels.QueuePage
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class PassQueueViewModel : BaseViewModel
    {
        public ObservableCollection<PassQueue> Passes { get; set; }
        public ICommand ButtonTapped { private set; get; }

        public PassQueueViewModel()
        {
            Passes = new ObservableCollection<PassQueue>();


            Passes.Add(new PassQueue
            {
                studentName = "Imaan Ali",
                className = " Honors Chemistry",
                signOutTime = "6:52",
                signInTime = "7:01",
                timeRemaining = "--:--"
            });
            Passes.Add(new PassQueue
            {
                studentName = "Taranveer Flora",
                className = " Honors Calculus",
                signOutTime = "8:54",
                signInTime = "9:00",
                timeRemaining = "--:--"
            });
            Passes.Add(new PassQueue
            {
                studentName = "Aidan Fleming",
                className = " Advanced Data Structures",
                signOutTime = "9:36",
                signInTime = "9:40",
                timeRemaining = "--:--"
            });
            Passes.Add(new PassQueue
            {
                studentName = "Josh Averion",
                className = " Honors British Literature",
                signOutTime = "6:52",
                signInTime = "7:01",
                timeRemaining = "--:--"
            });
            Passes.Add(new PassQueue
            {
                studentName = "Samyukta Neeraj",
                className = " AP Physics",
                signOutTime = "6:52",
                signInTime = "--:--",
                timeRemaining = "3:36"
            });
            Passes.Add(new PassQueue
            {
                studentName = "Denise Kaur",
                className = " AP Calculus BC",
                signOutTime = "6:52",
                signInTime = "--:--",
                timeRemaining = "4:12"
            });
            Passes.Add(new PassQueue
            {
                studentName = "Megumi Barclay",
                className = " AP Language & Composition",
                signOutTime = "6:52",
                signInTime = "--:--",
                timeRemaining = "1:38"
            });
            Passes.Add(new PassQueue
            {
                studentName = "LeBron James",
                className = " AP Environnmetal Science",
                signOutTime = "6:52",
                signInTime = "--:--",
                timeRemaining = "2:59"
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
