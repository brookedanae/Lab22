using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class MovieViewModel
    {

        public MovieViewModel(string title, MovieGenre genre, string actors, string year)
        {
            Title = title;
            Genre = genre;
            Actors = actors;
            Year = year;
        }

        [Display(Name = "Title")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; }

        [Display(Name = "Genre")]
        [Required]
        public MovieGenre Genre { get; }

        [Display(Name = "Actors")]
        [Required]
        public string Actors { get; set; }

        [Display(Name = "Year")]
        [Required]
        public string Year { get; set; }
    }
}
