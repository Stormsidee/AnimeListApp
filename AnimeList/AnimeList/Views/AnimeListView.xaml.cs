using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeList.Models;
using AnimeList.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimeListView : ContentPage
    {

        public AnimeListView()
        {
            InitializeComponent();
            BindingContext = new AnimeListViewModel() { Navigation = this.Navigation };

        }

    }
}