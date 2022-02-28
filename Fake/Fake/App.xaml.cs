using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fake
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutR { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
