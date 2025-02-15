using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        // Title field: Ensuring proper length and required validation with a clear error message
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 60 characters.")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        // Release Date field: Ensuring it's required and formatted properly
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release Date is required.")]
        public DateTime ReleaseDate { get; set; }

        // Genre field: Required validation, ensuring it starts with a capital letter and contains only letters/spaces
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Genre must start with a capital letter and contain only letters and spaces.")]
        [Required(ErrorMessage = "Genre is required.")]
        [StringLength(30, ErrorMessage = "Genre must be 30 characters or fewer.")]
        public string Genre { get; set; }

        // Price field: Defined explicitly to prevent truncation (decimal(18,2)), required, and range-limited
        [Range(1, 100, ErrorMessage = "Price must be between 1 and 100.")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price is required.")]
        [Column(TypeName = "decimal(18,2)")] // Ensures precision in the database
        public decimal Price { get; set; }

        // Rating field: Required validation, limited to 5 characters
        [StringLength(5, ErrorMessage = "Rating cannot exceed 5 characters.")]
        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }
    }
}
