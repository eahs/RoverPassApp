using RoverPass.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model = RoverPass.Models.ClassesPage;


namespace RoverPass.ViewModels.Destination
{
    /// <summary>
    /// ViewModel for My Article page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class MyArticlePageViewModel : BaseViewModel
    {
        public ObservableCollection<PassType> Denstinations { get; set; }
        //public ICommand ButtonTapped { private set; get; }

        public MyArticlePageViewModel()
        {
            Denstinations = new ObservableCollection<PassType>();


            Denstinations.Add(new PassType
            {
                Name = "Bathroom"
            });
            Denstinations.Add(new PassType
            {
                Name = "Library"
            });
            Denstinations.Add(new PassType
            {
                Name = "Guidance"
            });
            Denstinations.Add(new PassType
            {
                Name = "PE Department"
            });
            Denstinations.Add(new PassType
            {
                Name = "Grade Level Office"
            });
            Denstinations.Add(new PassType
            {
                Name = "Main Office"
            });
            Denstinations.Add(new PassType
            {
                Name = "Teacher's Room"
            });
            Denstinations.Add(new PassType
            {
                Name = "Security Desk"
            });
            Denstinations.Add(new PassType
            {
                Name = "Water Fountain"
            });
            Denstinations.Add(new PassType
            {
                Name = "Other"
            });
            //ButtonTapped = new Command(HandleButton);
        }

        //private async void HandleButton(object obj)
        // {
        //    Class c = obj as Class;

            // c is the class they clicked on
        //    await Shell.Current.GoToAsync("DestinationPage");
        //}

    }
}
