using System.ComponentModel;
using Xamarin.Forms;
using RoverPass.ViewModels;

namespace RoverPass.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}