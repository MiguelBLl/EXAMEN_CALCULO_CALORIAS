using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMEN_CALCULO_CALORIAS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
               
        public Page2()
        {
            InitializeComponent();
         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) &&
                !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var cal = peso / (altura * altura);
                CAL.Text = cal.ToString();

                string resultado = "";

                if (cal < 18.5)
                {
                    resultado = "CALORIAS BAJAS";
                }
                else if (cal >= 18.5 && cal <= 24.9)
                {
                    resultado = "CALORIA NORMAL";
                }
                else if (cal >= 25 && cal <= 29.9)
                {
                    resultado = "EN EXCESO";
                }
                else
                {
                    resultado = "ALTAS CALORIAS, ¡PRECAUSION!";
                }

                DisplayAlert("RESULTADO", resultado, "Ok");
            }
            else
            {
                DisplayAlert("Datos erróneos",
                    "Por favor, llena toda la información",
                    "Ok");
            }

        }
    }
}