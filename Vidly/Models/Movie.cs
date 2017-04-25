using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        
        public int Id { get; set; }

        [Required]
        [IsMovieStockNumberBetween1And20]
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenresId { get; set; }

        public Genres Genre { get; set; }

        public static readonly int MinStockNumber = 1;
        public static readonly int MaxStockNumber = 20;








    }

  
}