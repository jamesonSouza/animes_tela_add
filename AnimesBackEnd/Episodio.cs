using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AnimesBackEnd
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Episodio
    {
     //   [JsonProperty("id")]
      //  public long Id { get; set; }

        [JsonProperty("urlImage")]
        public string UrlImage { get; set; }

        [JsonProperty("urlVideo")]
        public string UrlVideo { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("numEpsodio")]
        public long NumEpsodio { get; set; }

        //[JsonProperty("temporada")]
      //  public Temporada Temporada { get; set; }
    }

    

    public partial class Episodio
    {
        public static Episodio FromJson(string json) => JsonConvert.DeserializeObject<Episodio>(json, AnimesBackEnd.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Episodio self) => JsonConvert.SerializeObject(self, AnimesBackEnd.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }



    class EpisodioComID
    {
        [JsonProperty("id")]
         public long Id { get; set; }

        [JsonProperty("urlImage")]
        public string UrlImage { get; set; }

        [JsonProperty("urlVideo")]
        public string UrlVideo { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("numEpsodio")]
        public long NumEpsodio { get; set; }

       // [JsonProperty("temporada")]
        //public Temporada Temporada { get; set; }
    }
    class EpisodioPut
    {
       

        [JsonProperty("urlImage")]
        public string UrlImage { get; set; }

        [JsonProperty("urlVideo")]
        public string UrlVideo { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("numEpsodio")]
        public long NumEpsodio { get; set; }

        // [JsonProperty("temporada")]
        //public Temporada Temporada { get; set; }
    }
}