using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CodeRefactoring.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(Constants.UserConstants.FirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(Constants.UserConstants.LastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;
    }
}