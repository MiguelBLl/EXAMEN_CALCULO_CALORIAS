using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EXAMEN_CALCULO_CALORIAS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btn1.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Page2());
            };
        }
    }
}

