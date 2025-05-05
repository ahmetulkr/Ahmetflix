using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ahmetflix.Models
{
    public class Series
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }
        public string BackdropPath { get; set; }
        public double VoteAverage { get; set; }
        public DateTime FirstAirDate { get; set; }
        public DateTime LastAirDate { get; set; }
        public int EpisodeRunTime { get; set; }
        public int NumberOfSeasons { get; set; }
        public string Status { get; set; }
        public string Genres { get; set; }
        public string OriginalLanguage { get; set; }
        public List<Season> Seasons { get; set; }
        public List<Cast> Casts { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IMDB Imdb { get; set; }
    }

    public class Season
    {
        [Key]
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }
        public int EpisodeCount { get; set; }
    }

    public class Cast
    {
        [Key]
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public string ProfilePath { get; set; }
    }

    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class IMDB
    {
        [Key]
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public double Rating { get; set; }
        public int VoteCount { get; set; }
    }
}
