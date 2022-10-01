using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AnimeList.Views;
using System.IO;



namespace AnimeList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Sharpnado.CollectionView.Initializer.Initialize(true, false);
            MainPage = new NavigationPage(new AnimeListView());
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
