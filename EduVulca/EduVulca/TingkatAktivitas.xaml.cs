using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EduVulca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TingkatAktivitas : ContentPage
    {
        public TingkatAktivitas()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            string url = "https://www.cnbcindonesia.com/news/20221204184407-4-393605/memahami-4-level-status-gunung-api-dari-normal-sampai-awas";

            await Launcher.OpenAsync(new Uri(url));
        }
    }
}