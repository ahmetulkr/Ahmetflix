using System.ComponentModel.DataAnnotations;

namespace Ahmetflix.Models
{
    public class Series
    {
        [Key]
        public int Id { get; set; }
        public string? SeriesName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Count { get; set; }
        public string? Image {  get; set; }
        public string? Subtitle { get; set; }
        public string? Genre { get; set; }
        public string? Country { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IMDB Imdb { get; set; }


    }
}
