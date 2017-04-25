using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class IsMovieStockNumberBetween1And20 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            return
                (movie.NumberInStock >= Movie.MinStockNumber && movie.NumberInStock <= 20)
                    ? ValidationResult.Success
                    : new ValidationResult("The stock number must be between 1 and 20");



        }
    }
}