using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Namespace
{
    public class Stoka
    {
        public Stoka()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("Product name")]
        public String Name { get; set; }

        [Required]
        [Comment("Broq koito imame za produkta")]
        public string Qty { get; set; } = "0";

        [Required]
        [MaxLength(1_000)]
        [Comment("Product description")]
        public string Opisanie { get; set; }

        [Required]
        [Comment("Price in unknown currency")]
        public string Cena { get; set; }
    }
}