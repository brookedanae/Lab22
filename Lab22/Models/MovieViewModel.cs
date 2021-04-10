using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class MovieViewModel
    {

        public MovieViewModel(string title, string genre)
        {
            Title = Title;
            Genre = genre;
        }

        [Display(Name = "Title")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; }

        [Display(Name = "Genre")]
        [Required]
        public string Genre { get; }

        [Display(Name = "Year")]
        public string Year { get; set; }

        [Display(Name = "Actors")]
        public string Actors { get; set; }

        [Display(Name = "Directors")]
        public string Directors { get; set; }
    }
}
