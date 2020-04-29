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
        public Serie DetailSerie = new Serie();

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

        private string overview;
        public string Overview
        {
            get => overview;
            set
            {
                overview = value;
                OnPropertyChanged();
            }
        }
        private string releaseDate;
        public string ReleaseDate
        {
            get => releaseDate;
            set
            {
                releaseDate = value;
                OnPropertyChanged();
            }
        }

        private string backdrop;
        public string BackDrop
        {
            get => backdrop;
            set
            {
                backdrop = value;
                OnPropertyChanged();
            }
        }
        private double vote_average;
        public double Vote_Average
        {
            get => vote_average;
            set
            {
                vote_average = value;
                OnPropertyChanged();
            }
        }

        public DetailViewModel(Serie serie) : base("")
        {
            DetailSerie = serie;
            Title = serie.Name;
            Image = serie.Poster;
            Name = string.IsNullOrEmpty(serie.Name) ? string.Empty : serie.Name.ToUpper();
            Overview = serie.Overview;
            ReleaseDate = serie.ReleaseDate;
            BackDrop = serie.BackDrop;
            Vote_Average = serie.VoteAverage;
        }
    }
        
}
