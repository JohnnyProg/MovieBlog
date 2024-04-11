using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tytu� jest wymagany")]
        [MaxLength(50, ErrorMessage = "Maksymalna d�ugo�� tytu�u to 50")]
        public string Title { get; set; }

        [UIHint("LongText")]
        [Required(ErrorMessage = "Opis jest wymagany"), ]
        public string Description { get; set; }

        [UIHint("Stars")]
        [Range(1, 5, ErrorMessage = "Ocena filmu musi by� liczb� pomi�dzy 1 a 5")]
        public int Rating { get; set; }
        public string? TrailerLink { get; set; }
        public Genre Genre { get; set; }
    }
}
