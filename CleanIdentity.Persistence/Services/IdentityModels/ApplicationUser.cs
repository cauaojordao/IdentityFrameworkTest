using Microsoft.AspNetCore.Identity;
using CleanIdentity.Domain.Entities;

namespace CleanIdentity.Persistence.Services.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<AppFile> Files { get; set; } = new List<AppFile>();
    }
}
