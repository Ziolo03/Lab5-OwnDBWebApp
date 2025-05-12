using System.ComponentModel.DataAnnotations;

namespace Lab5_OwnDBWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Range(0, 10, ErrorMessage = "Rate must be between 0 and 10")]
        public float? Rate { get; set; }

        public string? UserId { get; set; }

        public string? UserName { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string? ImageUrl { get; set; }
    }
}
