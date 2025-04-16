using ApiLocadora.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Dtos
{
    public class FilmDto
    {

        [Required]
        public required string Name { get; set; }
        [Required]
        public required DateTime ReleaseDate { get; set; }
        [Required]
        public required string Director { get; set; }
        [Required]
        public required List<Genre> Genre { get; set; }
        [Required]
        public required Studio Studio { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required double AvaliationIMDB { get; set; }



    }
}
