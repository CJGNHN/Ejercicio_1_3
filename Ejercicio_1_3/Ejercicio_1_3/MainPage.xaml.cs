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

        private async void Agregar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync( new Views.CrearPersonas());
            
        }

    }

    }
