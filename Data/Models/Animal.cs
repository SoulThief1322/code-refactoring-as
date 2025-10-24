using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeRefactoring.Constants;
namespace CodeRefactoring.Data.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(AnimalConstants.NameMaxLength)]
        public string Name = string.Empty;
        public User Owner { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = string.Empty;

        [Required]
        [Range(AnimalConstants.AgeMinNumber, AnimalConstants.AgeMaxNumber)]
        public int Age;
        public string Type = string.Empty;
        [Required]
        public bool IsSick = false;
        [Required]
        [MaxLength(AnimalConstants.NotesMaxLength)]
        public string Notes = "";

        public void MakeOlder()
        {
            Age += 3;
        }

        public void Heal()
        {
            IsSick = false;
            Notes = "feeling ok i guess";
        }
    }
}