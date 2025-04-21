using System.ComponentModel.DataAnnotations;

namespace BookManagerAPI.DTOs
{
    public class BookCreateDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string Author { get; set; }

        [Required]
        [Range(1000, 3000)]
        public int Year { get; set; }

        [Required]
        [MaxLength(100)]
        public string Genre { get; set; }

        public int? CategoryId { get; set; }
    }
}
