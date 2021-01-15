using RoverPass.ViewModels.HallMonitor;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.HallMonitor
{
    /// <summary>
    /// About us simple page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HallMonitor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:RoverPass.Views.HallMonitor.AboutUsSimplePage"/> class.
        /// </summary>
        public HallMonitorViewModel vmmm;


        public HallMonitor()
        {
            InitializeComponent();

            vmmm = new HallMonitorViewModel();
            this.BindingContext = vmmm;

        }
    }
}