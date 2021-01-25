using System.Collections.ObjectModel;
using RoverPass.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model = RoverPass.Models.ClassesPage;

namespace RoverPass.ViewModels.BathroomPass
{
    /// <summary>
    /// ViewModel for My Article page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class BathroomPassViewModel : CountdownViewModel
    {
        
            public ObservableCollection<PassControl> PassCommands { get; set; }
           // public ICommand ButtonTapped { private set; get; }

            public BathroomPassViewModel()
            {
                PassCommands = new ObservableCollection<PassControl>();


                PassCommands.Add(new PassControl
                {
                    PassCommand = "Start"
                });
                PassCommands.Add(new PassControl
                {
                    PassCommand = "End"
                });


                //ButtonTapped = new Command(HandleButton);
            }

            //private async void HandleButton(object obj)
            //{
            //    Class c = obj as Class;

                // c is the class they clicked on
            //    await Shell.Current.GoToAsync("DestinationPage");
            //}

        }
    

}
