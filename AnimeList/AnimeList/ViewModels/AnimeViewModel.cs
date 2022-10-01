using System;
using System.ComponentModel;
using AnimeList.Models;
using Xamarin.Forms;

namespace AnimeList.ViewModels
{
   public class AnimeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        AnimeListViewModel Animevm;
        public bool IsSelected { get; set; }
        public Anime Anime { get; private set; }
        public AnimeViewModel()
        {
            Anime = new Anime();
        }
        public AnimeListViewModel ListViewModel
        {
            get { return Animevm; }
            set
            {
                if (Animevm != value)
                {
                    Animevm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Title
        {
            get { return Anime.Title; }
            set
            {
                if(Anime.Title != value)
                {
                    Anime.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public string Season
        {
            get { return Anime.Season; }
            set
            {
                if (Anime.Season != value)
                {
                    Anime.Season = value;
                    OnPropertyChanged("Season");
                }
            }
        }

        public string Score
        {
            get { return Anime.Score; }
            set
            {
                if (Anime.Score != value)
                {
                    Anime.Score = value;
                    OnPropertyChanged("Score");
                }
            }
        }
        public string RealeseDate
        {
            get { return Anime.RealeseDate; }
            set
            {
                if (Anime.RealeseDate != value)
                {
                    Anime.RealeseDate = value;
                    OnPropertyChanged("RealeseDate");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return (!string.IsNullOrEmpty(Title.Trim())) ||
                    (!string.IsNullOrEmpty(Season.Trim())) ||
                    (!string.IsNullOrEmpty(Score.Trim())) ||
                    (!string.IsNullOrEmpty(RealeseDate.Trim()));
            }
        }


        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
