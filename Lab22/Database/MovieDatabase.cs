using Lab22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Database
{
    public class MovieDatabase : IMovieDatabase
    {
        public List<MovieViewModel> Get()
        {
            var result = new List<MovieViewModel>();

            result.Add(new MovieViewModel("What About Bob?", "Comedy"));
            result.Add(new MovieViewModel("Seven", "Thriller"));
            result.Add(new MovieViewModel("Whiplash", "Drama"));
            result.Add(new MovieViewModel("Liar Liar", "Comedy"));
            result.Add(new MovieViewModel("Gone in 60 Seconds", "Action"));
            result.Add(new MovieViewModel("The Conjuring", "Horror"));
            result.Add(new MovieViewModel("Space Jam", "Comedy"));
            result.Add(new MovieViewModel("Now and Then", "Drama"));
            result.Add(new MovieViewModel("Us", "Horror"));
            result.Add(new MovieViewModel("Jurassic Park", "Action"));
            result.Add(new MovieViewModel("Forrest Gump", "Drama"));
            result.Add(new MovieViewModel("Clueless", "Drama"));
            result.Add(new MovieViewModel("The Fast and The Furious", "Action"));
            result.Add(new MovieViewModel("The Strangers", "Horror"));
            result.Add(new MovieViewModel("Predator", "Scifi"));
        }
    }
}
