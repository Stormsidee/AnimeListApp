using System.Windows.Input;
using System.Collections.ObjectModel;
using AnimeList.Views;
using System.ComponentModel;
using AnimeList.Models;
using Xamarin.Forms;


namespace AnimeList.ViewModels
{
    public class AnimeListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AnimeViewModel> Anime { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateCommand { protected set; get; }
        public ICommand DeleteCommand { protected set; get; }
        public ICommand SaveCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        public ICommand ListTapCommand { protected set; get; }

        public INavigation Navigation { get; set; }

        public AnimeListViewModel()
        {
            Anime = new ObservableCollection<AnimeViewModel>();
            CreateCommand = new Command(Create);
            DeleteCommand = new Command(Delete);
            SaveCommand = new Command(Save);
            BackCommand = new Command(Back);
            ListTapCommand = new Command(OnListTap);

        }

        public void OnListTap(object tappedItem)
        { 
            foreach(var item in Anime)
            {
                item.IsSelected = item == tappedItem;
            }
            Navigation.PushAsync(new AnimePage((AnimeViewModel)tappedItem));
            
        }
 
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


        private void Create()
        {
            Navigation.PushAsync(new AnimePage(new AnimeViewModel() {ListViewModel = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void Save(object animeObject)
        {
            AnimeViewModel anime = animeObject as AnimeViewModel;
            if (anime != null && anime.IsValid && !Anime.Contains(anime))
            {
                Anime.Add(anime);
 
            }
            Back();
        }
        private void Delete(object animeObject)
        {
            AnimeViewModel anime = animeObject as AnimeViewModel;
            if(anime != null)
            {
                Anime.Remove(anime);
            }
            Back();
        }
    }
}
