using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1_3.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_1_3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearPersonas : ContentPage
    {
        public CrearPersonas()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var perso = new Personas
            {
                nombres = tnombre.Text,
                apellidos = tapellido.Text,
                edades = Convert.ToInt32(tedad.Text),
                correos = tcorreo.Text,
                direccion = tdireccion.Text
            };

            var resultado = await App.BaseDatos.GuardarPersonas(perso);

            if (resultado != 0)
                await DisplayAlert("Mensaje", "Persona ingresada con exito","OK");
            else
                await DisplayAlert("Mensje", "Error", "OK");
            await Navigation.PopAsync();

        }
    }
}