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
    public partial class MyArticlePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyArticlePage"/> class.
        /// </summary>
        public MyArticlePage()
        {
            InitializeComponent();
        }

        private async void Bathroom_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//BathroomPass");
        }
    }
}