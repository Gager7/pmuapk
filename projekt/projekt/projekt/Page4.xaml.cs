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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
            slika2.Source = ImageSource.FromResource("projekt.slike.ruke.png");
            slika3.Source = ImageSource.FromResource("projekt.slike.prsa.png");
            slika4.Source = ImageSource.FromResource("projekt.slike.leda.png");
            slika5.Source = ImageSource.FromResource("projekt.slike.stomak.png");
            slika6.Source = ImageSource.FromResource("projekt.slike.noge.png");
        }
    }
}