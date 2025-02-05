using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        // Title field: Ensure it has a minimum length and a required validation with a custom error message
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 60 characters.")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        // Release Date: If it's required, keep it as non-nullable. If optional, make it nullable (DateTime?).
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release Date is required.")]
        public DateTime ReleaseDate { get; set; }

        // Genre field: Required with a regex to ensure only valid characters
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Genre must start with a capital letter and contain only letters and spaces.")]
        [Required(ErrorMessage = "Genre is required.")]
        [StringLength(30, ErrorMessage = "Genre must be 30 characters or fewer.")]
        public string Genre { get; set; }

        // Price field: Range of 1 to 100 with currency data type
        [Range(1, 100, ErrorMessage = "Price must be between 1 and 100.")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        // Rating field: Required with a length of 5 characters and a custom error message
        [StringLength(5, ErrorMessage = "Rating cannot exceed 5 characters.")]
        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }
    }
}
