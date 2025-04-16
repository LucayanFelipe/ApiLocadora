using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Dtos
{
    public class GenreDto
    {
      
        [Required]
        public required string Name { get; set; }
    }
}
