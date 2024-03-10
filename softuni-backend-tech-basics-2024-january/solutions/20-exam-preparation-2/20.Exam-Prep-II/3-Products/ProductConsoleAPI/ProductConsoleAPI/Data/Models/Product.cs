using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProductConsoleAPI.Common;

namespace ProductConsoleAPI.Data.Models
{
    public class Product
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.ProductCodeMinLength)]
        [MaxLength(ValidationConstants.ProductCodeMaxLength)]
        public string ProductCode { get; set; }

        [Required]
        [MaxLength(ValidationConstants.ProductNameLength)]
        public string ProductName { get; set; }

        [Required]
        [Range(ValidationConstants.QuantityMinValue, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [Range(typeof(decimal), ValidationConstants.PriceMinValue, ValidationConstants.PriceMaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(ValidationConstants.CountryNameLength)]
        public string OriginCountry { get; set; }

        [Required]
        [MaxLength(ValidationConstants.DescriptionLength)]
        public string Description { get; set; }
    }
}
