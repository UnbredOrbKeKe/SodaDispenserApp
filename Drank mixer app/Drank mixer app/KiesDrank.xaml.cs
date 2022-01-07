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

        private void Pomp1_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp1");
        }

        private void Pomp2_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp2");
        }

        private void Pomp3_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp3");

        }

        private void Pomp4_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp4");
        }

        private void Pomp5_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp5");
        }

        private void Pomp6_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp6");
        }

        private void Pomp7_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp7");
        }

        private void Pomp8_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate("Pomp8");
        }

        private void Fris1_Clicked(object sender, EventArgs e)
        {
            string value = Arduino.CummunicateR("Fris1Status");
            Fris1Status.Text = Convert.ToString(value);
        }

        private void Fris2_Clicked(object sender, EventArgs e)
        {
            string value = Arduino.CummunicateR("Fris2Status");
            Fris2Status.Text = Convert.ToString(value);
            
            
        }

        private void Button_Clicked_pre(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_Custom(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_Settings(object sender, EventArgs e)
        {

        }
    }
}