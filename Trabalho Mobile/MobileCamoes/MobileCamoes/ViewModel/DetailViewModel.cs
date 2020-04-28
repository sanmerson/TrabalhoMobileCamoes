using MobileCamoes.Model;
using MobileCamoes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileCamoes.ViewModel
{
    public class DetailViewModel : ViewModelBase

    {
        /*
        private string image;
        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        */

        public Serie DetailSerie = new Serie();
        public DetailViewModel(Serie serie) : base("")
        {

             DetailSerie = serie;
        //     Title = serie.Name;
       //     Image = serie.Poster;
         //   Name = string.IsNullOrEmpty(serie.Name) ? string.Empty : serie.Name.ToUpper();
        }
    }
        
}
