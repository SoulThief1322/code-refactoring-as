using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using CodeRefactoring.Constants;
namespace CodeRefactoring.Models2
{
    public class Merchandise
    {
        public Merchandise()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(MerchandiseConstants.NameMaxLength)]
        [Comment("Product name")]
        public String Name { get; set; }

        [Required]
        [Comment("The quantity of the merchandise")]
        public string Quantity { get; set; } = "0";

        [Required]
        [MaxLength(MerchandiseConstants.DescriptionMaxLength)]
        [Comment("Product description")]
        public string Description { get; set; }

        [Required]
        [Comment("Price in unknown currency")]
        public string Price { get; set; }
    }
}