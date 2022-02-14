using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ejercicio_1_3;
using Xamarin.Forms.Xaml;
namespace Ejercicio_1_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Agregar_Clicked(object sender, EventArgs e)
        {

            //cp: Content Page
            var cpPersona = new Views.CrearPersonas();


            await Navigation.PushModalAsync(cpPersona);
        }

        private async void btnlista_Clicked(object sender, EventArgs e)
        {
            var cpPagePersona = new Views.PersonasPage();


            await Navigation.PushModalAsync(cpPagePersona);
        }
    }

    }
