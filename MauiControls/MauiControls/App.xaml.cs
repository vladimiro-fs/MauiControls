namespace MauiControls
{
    using MauiControls.Pages;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MauiEditControls());
        }
    }
}
