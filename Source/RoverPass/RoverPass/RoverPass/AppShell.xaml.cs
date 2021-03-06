﻿using System;
using System.Collections.Generic;
using RoverPass.ViewModels;
using RoverPass.Views;
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

            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
