using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmdatabasen.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string MovieCategory { get; set; }
        public string MovieTitle { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string ImdbUrl { get; set; }
    }
}
