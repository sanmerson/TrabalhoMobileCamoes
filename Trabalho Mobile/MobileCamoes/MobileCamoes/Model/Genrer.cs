using Newtonsoft.Json;
using System;
using System.Text;
using System.Collections.Generic;

namespace MobileCamoes.Model
{
    public class Genrer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
