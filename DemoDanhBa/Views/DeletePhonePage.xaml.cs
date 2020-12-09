using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using DemoDanhBa.Models;
using DemoDanhBa.ViewModel;

namespace DemoDanhBa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePhonePage : PopupPage
    {
        public DeletePhonePage()
        {
            InitializeComponent();
        }

        private void NoDeletePhone_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }

        private void YesDeletePhone_Tapped(object sender, EventArgs e)
        {




            //var button = sender as Button;
            //var person = button?.BindingContext as Person;

            //Page currentPage;
            //var vm = BindingContext as AddContactListViewModel;
            //vm?.RemoveComand.Execute(person);

        }
    }
}