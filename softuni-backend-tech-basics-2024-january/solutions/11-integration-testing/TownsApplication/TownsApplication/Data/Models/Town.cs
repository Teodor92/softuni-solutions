using System.ComponentModel.DataAnnotations;

namespace TownsApplication.Data.Models
{
    public class Town
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers allowed.")]
        public int Population { get; set; }
    }
}
