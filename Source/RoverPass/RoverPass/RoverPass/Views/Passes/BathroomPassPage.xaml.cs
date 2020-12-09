using RoverPass.ViewModels;
using RoverPass.ViewModels.BathroomPass;
using System;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.Passes
{
    /// <summary>
    /// Article with comments page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BathroomPassPage
    {
        BathroomPassViewModel vm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyArticlePage"/> class.
        /// </summary>
        public BathroomPassPage()
        {
            InitializeComponent();

            vm = (BathroomPassViewModel)BindingContext;
        }

        private void StartPass_Clicked(object sender, EventArgs e)
        {
            vm.Start(new TimeSpan(0, 15, 0));
        }

        private void EndPass_Clicked(object sender, EventArgs e)
        {
            vm.Stop();
        }
    }
}