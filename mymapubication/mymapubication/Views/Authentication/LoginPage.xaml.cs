using mymapubication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mymapubication.Views.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

        //private async void loginAcces_Clicked(object sender, EventArgs e)
        //{
        //    string username = TxtUser.Text;
        //    string password = TxtPassword.Text;

        //    if (IsValiDate(username, password))
        //    {
        //        await DisplayAlert("Mensaje", "Inicio exitoso", "ok");

        //        await Navigation.PushAsync(new MenuMajorPage());

        //    }
        //    else {

        //        await DisplayAlert("Error", "dato invalido", "ok");
        //    }
        //}

        //private bool IsValiDate(string username, string password)
        //{
        //    return username == "1" && password == "1234";
        //}
    }
}