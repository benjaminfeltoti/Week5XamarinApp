using System;
using Week5XamarinApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5XamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmployeeListPage());
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
