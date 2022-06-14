using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simple_Interest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Simple_Interest();
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
