using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using DemoDanhBa.ViewModel;
using DemoDanhBa.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoDanhBa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : PopupPage
    {
        public AddContactPage()
        {
            InitializeComponent();

        }

        public void ShowPersonInfo(string username, string phone)
        {
            UserName.Text = username;
            PhoneNumber.Text = phone;
        }

       private void Huy_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
           
        }
                
        private void Them_Clicked(object sender, EventArgs e)
        {
            //Person person = ((AddOrEditPersonViewModel)BindingContext).Person;
            //MessagingCenter.Send<App, Person>((App)Application.Current, "AddOrEditPerson", person);

            Person person = new Person();
            person.Name = UserName.Text;
            person.PersonPhone = PhoneNumber.Text;

            Page currentPage;
            //var model = BindingContext as AddContactListViewModel;
            //model.AddContact(person);

            if (Application.Current.MainPage.Navigation.NavigationStack.Count > 0)
            {
                int index = Application.Current.MainPage.Navigation.NavigationStack.Count - 1;
                currentPage = Application.Current.MainPage.Navigation.NavigationStack[index];
                string pageName = currentPage.ToString();
                if (pageName == "DemoDanhBa.Views.PhoneBookPage")
                {
                    var model = currentPage.BindingContext as AddContactListViewModel;
                    model.AddContact(person);
                }
            }

            Navigation.PopAsync();
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}