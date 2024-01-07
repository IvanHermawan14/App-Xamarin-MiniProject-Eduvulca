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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void DaftarButtonClicked(object sender, EventArgs e)
        {
            MySqlConnection koneksi = new MySqlConnection(Properties.Resources.db_con);
            koneksi.Open();

            MySqlCommand cmd = new MySqlCommand("select * from users where email  = '" + T_email.Text + "'", koneksi);
            var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                await DisplayAlert("Warning", "Email sudah terdaftar", "Close");
                T_email.Text = null;
                T_password.Text = null;
            }
            else
            {
                simpan();
                koneksi.Close();
            }
            
        }

        private async void simpan()
        {
            MySqlConnection koneksi = new MySqlConnection(Properties.Resources.db_con);
            
            koneksi.Open();

            MySqlCommand cmd = new MySqlCommand("insert into users (id, username, email, password) values ( '" + null + "', '" + T_user.Text + "', '" + T_email.Text + "', '" + T_password.Text + "')", koneksi);
            var rd = cmd.ExecuteReaderAsync();
            koneksi.Close();

            await DisplayAlert("INFO", "Registrasi Telah Berhasil", "Kembali");
            T_user.Text = null;
            T_email.Text = null;
            T_password.Text = null;
            await Navigation.PushAsync(new HomePage());           
        } 
    }
}