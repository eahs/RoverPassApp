using RoverPass.ViewModels.ClassesPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.ClassesPage

{
    /// <summary>
    /// Page to show the article profile
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Classes
    {
        public ClassesPageViewModel vm;

        /// <summary>
        /// Initializes a new instance of the <see cref="Classes" /> class.
        /// </summary>
        public Classes()
        {
            InitializeComponent();

            vm = new ClassesPageViewModel();
            this.BindingContext = vm;
        }

        private async void PreCalc_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("DestinationPage");
        }
        private async void AddNewClass_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("AddNewClassPage");
        }
    }
}