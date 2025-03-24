using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; } = string.Empty;
    }
}