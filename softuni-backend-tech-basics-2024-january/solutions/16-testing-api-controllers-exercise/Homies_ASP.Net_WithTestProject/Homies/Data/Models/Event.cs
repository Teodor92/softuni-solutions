using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Homies.Data.DataConstants;

namespace Homies.Data.Models
{
    public class Event
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(EventMaxName)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(EventMaxDescription)]
        public string Description { get; set; } = null!;

        [Required]
        public string OrganiserId { get; set; } = null!;

        [Required]
        //[ForeignKey(nameof(OrganiserId))]
        public IdentityUser Organiser { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public int TypeId { get; set; } 

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        //public ICollection<EventParticipant> EventsParticipants { get; set; } = new List<EventParticipant>();
    }
}
