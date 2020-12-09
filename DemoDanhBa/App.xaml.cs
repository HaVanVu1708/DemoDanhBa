using DemoDanhBa.Views;
using System;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Color = Xamarin.Forms.Color;

using System.IO;

using DemoDanhBa.Models;
using DemoDanhBa.ViewModel;


namespace DemoDanhBa
{
    public partial class App : Application
    {
    
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PhoneBookPage());

            BindingContext = new AddContactListViewModel();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.White;
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
