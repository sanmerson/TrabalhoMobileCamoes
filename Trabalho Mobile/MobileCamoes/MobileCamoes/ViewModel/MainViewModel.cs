using MobileCamoes.Model;
using MobileCamoes.Services;
using MobileCamoes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileCamoes.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public Serie MainSerie = new Serie();

        private string vote_average;
        public string VoteAverage
        {
            get => vote_average;
            set
            {
                vote_average = value;
                OnPropertyChanged();
            }
        }

        readonly ISerieService _serieService;

        public ICommand ItemClickCommand { get; }


        public ObservableCollection<Serie> Items { get; }

        public MainViewModel(ISerieService serieService) : base("Sanmerson - APP - Series")
        {
            _serieService = serieService;

            Items = new ObservableCollection<Serie>();

            ItemClickCommand = new Command<Serie>(async (item) => await ItemClickCommandExecute(item));

        }

        private async Task ItemClickCommandExecute(Serie item)
        {
            if (item != null)
            {
                await NavigationService.NavigateToAsync<DetailViewModel>(item);
            }
        }

        public override async Task InitializeAsync(object navgationData)
        {
            await base.InitializeAsync(navgationData);
            await LoadDataAsync();
        }


async Task LoadDataAsync()
        {
            var result = await _serieService.GetSeriesAsync();

            if(result != null)
            {
                foreach (Serie serie in result.Series)
                {
                    serie.Genrers = new List<Genrer>();
                   foreach (int genrer in serie.GenrersId)
                    {

                      try
                        {
                            serie.Genrers.Add(await _serieService.GetGenrerAsync(genrer));
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }

            AddItens(result);
        }

        private void AddItens(SerieResponse result)
        {
            Items.Clear();
            result?.Series.ToList()?.ForEach(i => Items.Add(i));
        }
    }
}
