using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static Eventmi.Infrastructure.GlobalConstants;

namespace Eventmi.Infrastructure.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(EventNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime Start {get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public string Place { get; set; } = null!;
    }
}
