using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Ahmetflix.Models
{
    public class Movie
    {
        [Key]
        public int Id{ get; set; }
        public string? MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Image { get; set; }
        public string? Genres { get; set; }
        public string? Subtitle { get; set; }
        public int Runtime { get; set; }
        public string? Country { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IMDB Imdb { get; set; }



    }
}
