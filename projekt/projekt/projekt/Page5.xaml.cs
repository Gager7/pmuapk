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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
            pick.ItemsSource = new List<string>()
            { 
                "Ruke",
                "Prsa",
                "Leđa",
                "Stomak",
                "Noge"
            };
        }
    }
}