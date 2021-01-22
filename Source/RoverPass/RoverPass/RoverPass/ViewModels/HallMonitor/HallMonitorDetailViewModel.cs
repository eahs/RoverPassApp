using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RoverPass.ViewModels.HallMonitor
{
    public class HallMonitorDetailViewModel : ContentView
    {
        public HallMonitorDetailViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }

                }
            };
        }
        
    }
}