﻿using System;
using Newtonsoft.Json;
using MobileCamoes.Infra;

namespace MobileCamoes.Model
{
    public class Serie
    {
        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_air_date")]
        public DateTimeOffset FirstAirDate { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("popularity")]
        public string Popularity { get; set; }

      //  [JsonProperty("genres")]
      //  public string Genres { get; set; }

      //  [JsonIgnore]
      //  public string Generos{ get { return $"{Genres}{Name}"; } }

        [JsonIgnore]
        public string ReleaseDate { get { return $"{FirstAirDate:dd/MM/yy}"; } }

        [JsonIgnore]
        public string Poster { get { return $"{AppSettings.ApiImageBaseUrl}{PosterPath}"; } }

        [JsonIgnore]
        public string BackDrop { get { return $"{AppSettings.ApiImageBaseUrl}{BackdropPath}"; } }
    }

}

