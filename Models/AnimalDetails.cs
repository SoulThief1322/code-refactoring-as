using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeRefactoring.Data.Models;
using CodeRefactoring.Constants;
namespace CodeRefactoring.Models
{
    public class AnimalDetails
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public User Owner { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = string.Empty;
        [Required]
        [Range(AnimalConstants.AgeMinNumber, AnimalConstants.AgeMaxNumber)]
        public int Age { get; set; }
        public string AnimalType { get; set; } = string.Empty;
        public bool IsSick { get; set; } = false;
        [Required]
        [MaxLength(AnimalConstants.NotesMaxLength)]
        public string Notes { get; set; } = string.Empty;
    }
}