using System;
using System.Collections.Generic;
using RoverPass.Models;
using RoverPass.Models.AddNewClass;
using RoverPass.ViewModels;
using RoverPass.Views;
using RoverPass.Views.AddNewClass;
using RoverPass.Views.ClassesPage;
using RoverPass.Views.Destination;

using RoverPass.Views.PassAproval;
using RoverPass.Views.Passes;
using Xamarin.Forms;


namespace RoverPass
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute("BathroomPassPage", typeof(BathroomPassPage));
            Routing.RegisterRoute("PassAproval", typeof(PassAproval));
            Routing.RegisterRoute("AddNewClassPage", typeof(AddNewClassPage));
            Routing.RegisterRoute("Classes", typeof(Classes));
            Routing.RegisterRoute("DestinationPage", typeof(DestinationPage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
