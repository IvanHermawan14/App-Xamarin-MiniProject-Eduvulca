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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        async void LoginButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginPage()); 
        }
        async void RegisterButtonClicked(object sender, EventArgs args)
        { 
            await Navigation.PushAsync(new RegisterPage()); 
        }
        async void InfoButtonClicked(object sender, EventArgs args)
        { 
            await Navigation.PushAsync(new AboutMe()); 
        }
    }
}