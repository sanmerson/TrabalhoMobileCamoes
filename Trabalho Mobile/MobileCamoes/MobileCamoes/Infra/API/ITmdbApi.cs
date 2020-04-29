﻿using Refit;
using System.Threading.Tasks;
using MobileCamoes.Model;

namespace MobileCamoes.Infra.API
{
    [Headers("Content-Type: application/json")]
    public interface ITmdbApi
    {
        [Get("/tv/popular?api_key={apiKey}")]
        Task<SerieResponse> GetSerieResponseAsync(string apiKey);

        [Get("/genre/{genrerId}?api_key={apiKey}")]
        Task<Genrer> GetGenrerAsync(int genrerId, string apiKey);
    }
}
