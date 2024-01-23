using mymapubication.Views.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mymapubication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMajorMenu : ContentPage
    {
        public PageMajorMenu()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}