using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDanhBa.ViewModel;
using DemoDanhBa.Models;




namespace DemoDanhBa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoneBookPage : ContentPage
    {
      
        public PhoneBookPage()
        {
            InitializeComponent();
            
        }

        private AddContactPage _popup = new AddContactPage();


        async void TapGestureRecognizer_Tapped_Add(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AddContactPage());
        }



        async void TapGestureRecognizer_Tapped_Delete(object sender, EventArgs e)
        {
            
            var _viewModel = BindingContext as AddContactListViewModel;

            var answer = await DisplayAlert("XÓA NGƯỜI LIÊN HỆ", "Ngay sau khi xóa bản sao người liên hệ này thì sẽ không thể hoàn tác.", "XÓA", "HỦY");
            
               
            if(answer == true )
            {
                Person item = (Person)((Image)sender).BindingContext;
                if (item == null) { return; }
                _viewModel.Removeperson(item.PersonId, item.PersonPhone, item.Name);
            }    
        }

        private void TapGestureRecognizer_Tapped_Edit(object sender, EventArgs e)
        {
            Person per = new Person(); // là person ở hàng chọn
            
            _popup.ShowPersonInfo("Nguyen Van A","0968978787");
            PopupNavigation.Instance.PushAsync(_popup);
        }
    }
}