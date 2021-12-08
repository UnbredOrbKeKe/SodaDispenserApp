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
        public bool pomp1 = true;
        public bool pomp2 = true;
        public bool pomp3 = true;
        public bool pomp4 = true;
        public bool pomp5 = true;
        public KiesDrank()
        {
            InitializeComponent();
        }

        private void Pomp1_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate(Convert.ToString(pomp1) + "1");
            pomp1 = !pomp1;
        }

        private void Pomp2_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate(Convert.ToString(pomp2) + "2");
            pomp2 = !pomp2;
        }

        private void Pomp3_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate(Convert.ToString(pomp3) + "3");
            pomp3 = !pomp3;
        }

        private void Pomp4_Clicked(object sender, EventArgs e)
        {
            Arduino.Cummunicate(Convert.ToString(pomp4) + "4");
            pomp4 = !pomp4;
        }
    }
}