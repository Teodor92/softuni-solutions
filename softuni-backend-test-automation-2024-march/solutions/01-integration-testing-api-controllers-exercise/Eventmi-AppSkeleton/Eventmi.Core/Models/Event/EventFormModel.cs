using Eventmi.Infrastructure.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static Eventmi.Infrastructure.GlobalConstants;

namespace Eventmi.Core.Models.Event
{
    public class EventFormModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(EventNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public string Place { get; set; } = null!;
    }
}
