using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;



namespace AnimeList.Models
{
    public class Anime
    {

        public string Title { get; set; }
        public string Season { get; set; }
        public string Score{ get; set; }
        public string RealeseDate { get; set; }
        public bool IsSelected { get; set; }
        
    }
}
