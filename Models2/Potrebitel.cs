using Microsoft.AspNetCore.Identity;

namespace Namespace
{
    public class Potrebitel : IdentityUser
    {
        public string purvoime { get; set; }
        public string LastName { get; set; }
    }
}