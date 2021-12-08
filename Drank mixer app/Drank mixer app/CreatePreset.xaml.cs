﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Drank_mixer_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePreset : ContentPage
    {
        public CreatePreset()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_pre(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KiesDrank());
        }

        private async void Button_Clicked_custom(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePreset());
        }

        private async void Button_Clicked_settings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}