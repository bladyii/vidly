using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genres")]
        public int? GenresId { get; set; }

        [Required]
        [IsMovieStockNumberBetween1And20]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public string PageHeading
        {
            get { return Id != 0 ? "Edit Movie" : "New Movie"; }
        }

        public Movie Movie { get; set; }
        public IEnumerable<Genres> Genres { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenresId = movie.GenresId;    
        }
    }
}