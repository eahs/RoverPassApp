using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.Destination
{
    /// <summary>
    /// Article with comments page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DestinationPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationPage"/> class.
        /// </summary>
        public DestinationPage()
        {
            InitializeComponent();
        }

        private async void Bathroom_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("BathroomPassPage");
        }
        private async void library_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("PassAproval");
        }

    }
}