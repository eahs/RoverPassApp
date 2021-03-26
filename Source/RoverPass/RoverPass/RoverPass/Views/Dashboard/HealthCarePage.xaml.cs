using RoverPass.ViewModels.Dashboard;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.Dashboard
{
    /// <summary>
    /// Page to show the health care details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HealthCarePage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCarePage" /> class.
        /// </summary>
        /// 
        public HealthCareViewModel vmmmmmmmm;
        public HealthCarePage()
        {
            
        InitializeComponent();
            vmmmmmmmm = new HealthCareViewModel();
            this.BindingContext = vmmmmmmmm;
        }
        private async void Bathroom_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("BathroomPassPage");
        }
    }
}
