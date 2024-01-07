using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EduVulca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class NewsItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl {get; set; }
    }
    public partial class News : ContentPage
    {
        public News()
        {
            InitializeComponent();
            List<NewsItem> newslist = new List<NewsItem>
            {
                new NewsItem {Title = "Dalam 6 Jam Terakhir, Gunung Merapi Muntahkan Belasan Kali Guguran Lava Pijar", Url = "https://news.okezone.com/read/2023/05/22/510/2817661/dalam-6-jam-terakhir-gunung-merapi-muntahkan-belasan-kali-guguran-lava-pijar", ImageUrl = "satu.jpg"},
                new NewsItem {Title = "Gunung Api Ile Lewotolok NTT Bergemuruh Kuat dan Muntahkan Lava Pijar", Url = "https://www.cnnindonesia.com/nasional/20230326121311-20-929452/gunung-api-ile-lewotolok-ntt-bergemuruh-kuat-dan-muntahkan-lava-pijar", ImageUrl = "dua.jpeg"},
                new NewsItem {Title = "Gunung Semeru Kembali Erupsi, Muntahkan Awan Panas", Url = "https://www.liputan6.com/tv/read/5286175/video-gunung-semeru-kembali-erupsi-muntahkan-awan-panas", ImageUrl = "tiga.jpeg"},
                new NewsItem {Title = "Gunung Ibu erupsi lontarkan abu setinggi 800 meter", Url = "https://www.antaranews.com/berita/3280107/gunung-ibu-erupsi-lontarkan-abu-setinggi-800-meter", ImageUrl = "empat.png"},
                new NewsItem {Title = "Status Gunung Karangetang Naik Jadi Siaga, Warga Dilarang Beraktivitas di Radius 2,5 Km dari Kawah Utama", Url = "https://regional.kompas.com/read/2023/05/19/121045278/status-gunung-karangetang-naik-jadi-siaga-warga-dilarang-beraktivitas-di", ImageUrl = "lima.jpg"},
                new NewsItem {Title = "Gunung Anak Krakatau Erupsi 7 Kali Pagi Ini", Url = "https://www.detik.com/sumut/berita/d-6529545/gunung-anak-krakatau-erupsi-7-kali-pagi-ini#:~:text=Gunung%20Anak%20Krakatau%20%28GAK%29%20kembali%20erupsi%20hari%20ini.,kini%20status%20GAK%20masih%20berada%20di%20Siaga%20III", ImageUrl = "enam.jpeg"},
            };

            NewsListView.ItemsSource = newslist;
        }
        private void NewsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var item = (NewsItem)e.SelectedItem;
                Device.OpenUri(new Uri(item.Url));
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}