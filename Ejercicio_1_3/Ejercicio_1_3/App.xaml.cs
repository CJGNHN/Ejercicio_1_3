using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicio_1_3.Models;
using System.IO;

namespace Ejercicio_1_3
{
    public partial class App : Application
    {
        static PersonasDB basedatos;

        public static PersonasDB BaseDatos
        {
            get
            {
                if(basedatos == null)
                {
                    basedatos = new PersonasDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PersonasDB.db3"));
                }
                return basedatos;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
