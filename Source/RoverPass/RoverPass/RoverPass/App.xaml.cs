using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RoverPass.Services;
using RoverPass.Views;
using MonkeyCache.FileStore;



namespace RoverPass
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = " https://roverpass.me/images/user/";

        public App()
        {
            Barrel.ApplicationId = "roverpass";

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY0ODI2QDMxMzgyZTMzMmUzMEhocnBHeEZYdVpiWDFtUTk5SzJtN0E2VCtLR2ZsSEFIcTlkMTRReW5NZm89");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
