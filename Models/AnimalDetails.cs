using System;

namespace CodeRefactoring.Models
{
    public class AnimalDetails
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public int Age { get; set; }
        public string AnimalType { get; set; } = string.Empty;
        public bool IsSick { get; set; } = false;
        public string Notes { get; set; } = string.Empty;
    }
}