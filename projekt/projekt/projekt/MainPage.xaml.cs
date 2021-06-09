using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using System.Collections.Generic;

namespace projekt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (ime.Text == null || email.Text == null || lozinka.Text == null || ime.Text.Length < 3 || email.Text.Length < 3 || lozinka.Text.Length < 3 || email.Text.Contains("@")==false)
            {
                await DisplayAlert("Pozor!", "Niste unijeli valjane podatke, molimo vas pokušajte ponovno.", "OK");
            }
            else
            {
                lista.ima = ime.Text;
                lista.mail = email.Text;
                lista.loz = lozinka.Text;
                await Navigation.PushAsync(new Page1());
            }
        }

        private async void Priv_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
