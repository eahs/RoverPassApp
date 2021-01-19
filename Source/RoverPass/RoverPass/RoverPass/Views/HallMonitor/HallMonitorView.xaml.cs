using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverPass.ViewModels.HallMonitor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoverPass.Views.HallMonitor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HallMonitorView : ContentPage
    {
        public HallMonitorViewModel vmmm;


        public HallMonitorView()
        {
            InitializeComponent();

            vmmm = new HallMonitorViewModel();
            this.BindingContext = vmmm;

        }
    }
}