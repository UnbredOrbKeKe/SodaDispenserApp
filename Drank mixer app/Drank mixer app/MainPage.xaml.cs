using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Drank_mixer_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

        }

        private async void BeginMix_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KiesDrank());

        }
    }
}
