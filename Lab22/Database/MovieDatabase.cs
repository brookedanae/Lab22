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

            result.Add(new MovieViewModel("What About Bob?", MovieGenre.Comedy, "Bill Murray", "1991"));
            result.Add(new MovieViewModel("Seven", MovieGenre.Thriller, "Morgan Freeman & Brad Pitt", "1997"));
            result.Add(new MovieViewModel("Whiplash", MovieGenre.Drama, "JK Simmons & Miles Teller", "2014"));
            result.Add(new MovieViewModel("Liar Liar", MovieGenre.Comedy, "Jim Carrey", "1997"));
            result.Add(new MovieViewModel("Gone in 60 Seconds", MovieGenre.Action, "Nicholas Cage & Angelina Jolie", "2000"));
            result.Add(new MovieViewModel("The Conjuring", MovieGenre.Horror, "Vera Farmiga & Patrick Wilson", "2013"));
            result.Add(new MovieViewModel("Space Jam", MovieGenre.Comedy, "Michael Jordan", "1996"));
            result.Add(new MovieViewModel("Now and Then", MovieGenre.Drama, "Christina Ricci & Demi Moore", "1995"));
            result.Add(new MovieViewModel("Us", MovieGenre.Horror, "Lupita Nyong'o & Elisabeth Moss", "2019"));
            result.Add(new MovieViewModel("Jurassic Park", MovieGenre.Action, "Sam Neill, Laura Dern & Jeff Goldblum", "1993"));
            result.Add(new MovieViewModel("Forrest Gump", MovieGenre.Drama, "Tom Hanks & Sally Fields", "1994"));
            result.Add(new MovieViewModel("Clueless", MovieGenre.Comedy, "Alicia Silverstone, Stacey Dash & Brittany Murphy", "1995"));
            result.Add(new MovieViewModel("The Fast and The Furious", MovieGenre.Action, "Paul Walker, Vin Diesel & Michelle Rodriguez", "2001"));
            result.Add(new MovieViewModel("The Strangers", MovieGenre.Horror, "Scott Speedman & Liv Tyler", "2008"));
            result.Add(new MovieViewModel("Annihilation", MovieGenre.Scifi, "Natalie Portman, Jennifer Jason Leigh, & Tessa Thompson", "2018"));

            return result;
        }


    }
}
