using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(); // pagina chamada
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
