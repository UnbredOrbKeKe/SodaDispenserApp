using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Drank_mixer_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KiesDrank : ContentPage
    {
        public KiesDrank()
        {
            InitializeComponent();
        }

        private void Cola_Clicked(object sender, EventArgs e)
        {
            kut.Text = Arduino.Cummunicate();
        }

        private void Sonnema_Clicked(object sender, EventArgs e)
        {

        }
    }
}