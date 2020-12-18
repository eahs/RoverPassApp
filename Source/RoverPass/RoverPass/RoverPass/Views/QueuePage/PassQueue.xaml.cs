using System;
using System.Collections.ObjectModel;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.QueuePage
{
    /// <summary>
    /// About us simple page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassQueue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:RoverPass.Views.QueuePage.AboutUsSimplePage"/> class.
        /// </summary>
        
        public class Employee
        {
            public string DisplayName { get; set; }
        }
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        //  public object EmployeeView { get; }

        public PassQueue()
        {
            InitializeComponent();
            //EmployeeView.ItemsSource = employees;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }


    }
}