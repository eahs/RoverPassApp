using System.Collections.ObjectModel;
using System.Windows.Input;
using RoverPass.Models;
using RoverPass.Models.HallMonitor;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RoverPass.ViewModels.HallMonitor
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    [Preserve(AllMembers = true)]
    public class HallMonitorViewModel : BaseViewModel
    {
        public ObservableCollection<Student> StudentNames { get; set; }
        
        public ICommand ButtonTapped1 { private set; get; }

        public HallMonitorViewModel()
        {
            StudentNames = new ObservableCollection<Student>();


            StudentNames.Add(new Student()
            {
                StudentName = "Taranveer Flora",
                GradeLevel = 11,
                PassType = "Bathroom"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "Imaan Ali",
                GradeLevel = 11,
                PassType = "Main Office"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "Josh Averion",
                GradeLevel = 11,
                PassType = "Computer Class"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "Aidan Fleming",
                GradeLevel = 11,
                PassType = "Library"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "Justin Gill",
                GradeLevel = 11,
                PassType = "Bathroom"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "Linda Hae",
                GradeLevel = 11,
                PassType = "Josh's Bedroom"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "Lebron James",
                GradeLevel = 12,
                PassType = "PE Department"
            });
            StudentNames.Add(new Student()
            {
                StudentName = "James Harden",
                GradeLevel = 12,
                PassType = "Nets"
            });
            ButtonTapped1 = new Command(MonitorButton);
        }

        private async void MonitorButton(object obj) 
        { 
            Student s = obj as Student;

         //s is the class they clicked on
           await Shell.Current.GoToAsync("HallMonitorView");
       }
    }
}