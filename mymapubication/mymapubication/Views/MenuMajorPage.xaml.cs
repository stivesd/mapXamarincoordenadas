using mymapubication.Views.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration.macOSSpecific;
using Xamarin.Forms.Xaml;

namespace mymapubication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMajorPage : ContentPage
    {
        public MenuMajorPage()
        {
            InitializeComponent();
        }

        private async void Datos_Tapped(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new PageGetCoordinates());

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = true;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();

        }

        private async void Datos_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFollowLifeCoord());
        }
    }
}