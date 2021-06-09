using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projekt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        async void Button_Clicked(object sender, EventArgs e)
        {
            if (email.Text == lista.mail && lozinka.Text == lista.loz)
            {
                await Navigation.PushAsync(new Page2());
            }
            else
            {
                await DisplayAlert("Pozor!","Netočni podatci, molimo vas pokušajte ponovno.","OK");
            }
        }

    }
}