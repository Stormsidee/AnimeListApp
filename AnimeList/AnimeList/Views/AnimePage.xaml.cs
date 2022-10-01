using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeList.ViewModels;
using AnimeList.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimePage : ContentPage
    {
        public AnimeViewModel ViewModel { get; private set; }
        
        public AnimePage(AnimeViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
            
        }

    }
}