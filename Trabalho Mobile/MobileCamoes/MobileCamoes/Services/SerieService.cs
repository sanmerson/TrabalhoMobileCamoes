using MobileCamoes.Infra;
using MobileCamoes.Infra.API;
using MobileCamoes.Model;
using System.Threading.Tasks;

namespace MobileCamoes.Services
{
    public class SerieService : ISerieService
    {
        readonly ITmdbApi _api;

        public SerieService(ITmdbApi api)
        {
            _api = api;
        }

        public async Task<SerieResponse> GetSeriesAsync()
        {
            return await _api.GetSerieResponseAsync(AppSettings.ApiKey);
        }

        public async Task<Genrer> GetGenrerAsync(int id)
        {
            return await _api.GetGenrerAsync(id, AppSettings.ApiKey);
        }
    }
}
