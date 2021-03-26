using Rg.Plugins.Popup.Services;
using RoverPass.ViewModels.QueuePage;
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

        public PassQueueViewModel vmmmmm;



        //  public object EmployeeView { get; }

        public PassQueue()
        {
            InitializeComponent();
            vmmmmm = new PassQueueViewModel();
            this.BindingContext = vmmmmm;
            //EmployeeView.ItemsSource = employees;

            // ObservableCollection allows items to be added after ItemsSource

        }
        private void OnPopupTask(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopTaskView());
        }

    }
}