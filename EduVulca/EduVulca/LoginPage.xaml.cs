using MySqlConnector;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {

            var koneksi = new MySqlConnection(Properties.Resources.db_con);
            koneksi.Open();

            var cmd = new MySqlCommand("select * from users where email  = '" + T_email.Text + "' && password= '" + T_pass.Text + "'", koneksi);
            var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                string username = rd["username"].ToString();
                Navigation.PushAsync(new MainPage());
                DisplayAlert("Selamat Datang", "Halo " + username + "! Selamat datang di aplikasi kami.", "OK");

            }
            else
            {
                DisplayAlert("Warning", "Username belum terdaftar atau password salah", "Close");
            }

            koneksi.Close();
        }
    }
}