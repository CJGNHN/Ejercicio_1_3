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
    public partial class PanelPersonas : ContentPage
    {
        public PanelPersonas()
        {
            InitializeComponent();
        }

        async private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            var perso = new Personas
            {
                codigo = Convert.ToInt32(tcodigo.Text),
                nombres = tnombre.Text,
                apellidos = tapellido.Text,
                edades = Convert.ToInt32(tedad.Text),
                correos = tcorreo.Text,
                direccion = tdireccion.Text
            };

            var resultado = await App.BaseDatos.GuardarPersonas(perso);

            if (resultado != 0)

                await DisplayAlert("Mensaje", "Persona Actualizada con exito", "OK");
           
            else
                await DisplayAlert("Mensaje", "Error", "OK");

        }
    

    async private void btnEliminar_Clicked(object sender, EventArgs e)
    {

    }
  }
}