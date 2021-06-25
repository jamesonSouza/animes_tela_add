using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimesBackEnd
{
    class Anime
    {
        
       public int id { get; set; }
        public string nome { get; set; }
        public string nomeAlternativo { get; set; }
        public string sinopse { get; set; }
        public string urlPoster { get; set; }
        public string autor { get; set; }
        public string estudio { get; set; }
        public string status { get; set; }
        public int ano { get; set; }
        public int numEpisodios { get; set; }
        public int temporadas { get; set; }
        public int likes { get; set; }


    }


    class AnimePut
    {


        public string nome { get; set; }
        public string nomeAlternativo { get; set; }
        public string sinopse { get; set; }
        public string urlPoster { get; set; }
        public string autor { get; set; }
        public string estudio { get; set; }
        public string status { get; set; }
        public int ano { get; set; }
        public int numEpisodios { get; set; }
        public int temporadas { get; set; }
        public int likes { get; set; }


    }
}
