using System.Collections.Generic;

namespace mpillajoS7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VISTAS.Inicio());
        }
    }
}
