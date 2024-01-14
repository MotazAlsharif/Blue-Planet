using BluePlanet2.view;

namespace BluePlanet2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            Routing.RegisterRoute(nameof(emamainpage), typeof(emamainpage));


        }
    }
}