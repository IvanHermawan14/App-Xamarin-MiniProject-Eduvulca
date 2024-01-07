using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EduVulca
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            mapWebView.Source = new UrlWebViewSource
            {
                Url = "https://www.google.com/maps/d/u/0/embed?mid=1BHiUCZC65q5VXRxns9F2gWbGYVl1Xdg&ehbc=2E312F"
            };
        }


        async void AktivitasButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TingkatAktivitas());
        }

        async void NewsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new News());
        }

        async void InformasiButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Informasi());
        }

    }
}
