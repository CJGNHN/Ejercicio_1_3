using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1_3;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_1_3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonasPage : ContentPage
    {
        public PersonasPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            ListaPersonas.ItemsSource = await App.BaseDatos.ListaPersonas();
        }

        private async void ListaPersonas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Personas items = (Models.Personas)e.Item;
            var newpage = new Views.PanelPersonas();
            newpage.BindingContext = items;
            await Navigation.PushModalAsync(newpage);
        }
    }

}
