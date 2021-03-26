using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopTaskView 
    {
        public PopTaskView()
        {
            InitializeComponent();
        }
       

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }
        private async void Button_OnClicked1(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }
    }
}