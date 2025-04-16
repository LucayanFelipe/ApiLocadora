using System.ComponentModel.DataAnnotations;

namespace ApiLocadora.Dtos
{
    public class StudioDto
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Distributor { get; set; }
    }
}
