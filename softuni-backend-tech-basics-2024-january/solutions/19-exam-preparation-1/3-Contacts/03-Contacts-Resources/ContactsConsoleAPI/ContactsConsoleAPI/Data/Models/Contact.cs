using ContactsConsoleAPI.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsConsoleAPI.Data.Models
{
    public class Contact
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.NameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.NameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(ValidationConstants.PhoneMaxLength)]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(ValidationConstants.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(ValidationConstants.GenderMaxLength)]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(ValidationConstants.ULIDRegex)]
        public string Contact_ULID { get; set; }
    }

}
