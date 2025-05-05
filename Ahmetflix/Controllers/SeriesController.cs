using Microsoft.AspNetCore.Mvc;
using Ahmetflix.Models;
using System.Collections.Generic;

namespace Ahmetflix.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            // Örnek dizi listesi
            var series = new List<Series>
            {
                new Series
                {
                    Id = 1,
                    Title = "Breaking Bad",
                    Overview = "Lisede kimya öğretmeni olan Walter White, bir oto yıkamada ek iş yapmaktadır ancak bir süre sonra ileri derecede akciğer kanseri olduğunu öğrenir...",
                    PosterPath = "https://image.tmdb.org/t/p/w500/ggFHVNu6YYI5L9pCfOacjizRGt.jpg",
                    BackdropPath = "https://image.tmdb.org/t/p/original/tsRy63Mu5cu8etL1X7ZLyf7UP1M.jpg",
                    VoteAverage = 8.9,
                    FirstAirDate = new DateTime(2008, 1, 20),
                    LastAirDate = new DateTime(2013, 9, 29),
                    EpisodeRunTime = 45,
                    NumberOfSeasons = 5,
                    Status = "Tamamlandı",
                    Genres = new List<string> { "Drama", "Suç" },
                    OriginalLanguage = "en",
                    Seasons = new List<Season>
                    {
                        new Season
                        {
                            Id = 1,
                            Name = "Sezon 1",
                            Overview = "İlk sezon, Walter White'ın kanser teşhisi konulduktan sonra ailesinin geleceğini güvence altına almak için uyuşturucu üretmeye başlamasını konu alır.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/1J2hEcQlgzyPTmWX8TpSFhLk0nZ.jpg",
                            EpisodeCount = 7
                        }
                    },
                    Casts = new List<Cast>
                    {
                        new Cast
                        {
                            Id = 1,
                            Name = "Bryan Cranston",
                            Character = "Walter White",
                            ProfilePath = "https://image.tmdb.org/t/p/w500/3gJpBpM8irfZbqC0f8kCTZg3FfR.jpg"
                        }
                    }
                }
            };

            return View(series);
        }

        public IActionResult Details(int id)
        {
            // Örnek dizi detayı
            var series = new Series
            {
                Id = 1,
                Title = "Breaking Bad",
                Overview = "Lisede kimya öğretmeni olan Walter White, bir oto yıkamada ek iş yapmaktadır ancak bir süre sonra ileri derecede akciğer kanseri olduğunu öğrenir...",
                PosterPath = "https://image.tmdb.org/t/p/w500/ggFHVNu6YYI5L9pCfOacjizRGt.jpg",
                BackdropPath = "https://image.tmdb.org/t/p/original/tsRy63Mu5cu8etL1X7ZLyf7UP1M.jpg",
                VoteAverage = 8.9,
                FirstAirDate = new DateTime(2008, 1, 20),
                LastAirDate = new DateTime(2013, 9, 29),
                EpisodeRunTime = 45,
                NumberOfSeasons = 5,
                Status = "Tamamlandı",
                Genres = new List<string> { "Drama", "Suç" },
                OriginalLanguage = "en",
                Seasons = new List<Season>
                {
                    new Season
                    {
                        Id = 1,
                        Name = "Sezon 1",
                        Overview = "İlk sezon, Walter White'ın kanser teşhisi konulduktan sonra ailesinin geleceğini güvence altına almak için uyuşturucu üretmeye başlamasını konu alır.",
                        PosterPath = "https://image.tmdb.org/t/p/w500/1J2hEcQlgzyPTmWX8TpSFhLk0nZ.jpg",
                        EpisodeCount = 7
                    }
                },
                Casts = new List<Cast>
                {
                    new Cast
                    {
                        Id = 1,
                        Name = "Bryan Cranston",
                        Character = "Walter White",
                        ProfilePath = "https://image.tmdb.org/t/p/w500/3gJpBpM8irfZbqC0f8kCTZg3FfR.jpg"
                    }
                }
            };

            return View(series);
        }
    }
}
