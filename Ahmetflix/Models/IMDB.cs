using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.ComponentModel.DataAnnotations;

namespace Ahmetflix.Models
{
    public class IMDB
    {

        public int Id { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

        public int VoteCount { get; set; }
        public int? MovieId { get; set; }
        public Movie Movie { get; set; }

        public int? SeriesId { get; set; }
        public Series Series { get; set; }


    }
}
