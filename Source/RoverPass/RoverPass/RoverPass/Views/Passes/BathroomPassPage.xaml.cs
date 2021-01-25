using RoverPass.ViewModels;
using RoverPass.ViewModels.BathroomPass;
using System;
using Xamarin.Forms;
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
        BathroomPassViewModel vmmmmm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyArticlePage"/> class.
        /// </summary>
        public BathroomPassPage()
        {
            InitializeComponent();

            vmmmmm = new BathroomPassViewModel();
            this.BindingContext = vmmmmm;

        }

        private void StartPass_Clicked(object sender, EventArgs e)
        {
            vmmmmm.Start(new TimeSpan(0, 10, 0));
        }
        private void EndPass_Clicked(object sender,EventArgs e)
       {
        vmmmmm.Stop();
            
            

        }
        
       
       
    }
}