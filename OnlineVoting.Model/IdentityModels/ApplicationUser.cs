using Microsoft.AspNetCore.Identity;

namespace OnlineVoting.Model.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser(string userName) : base(userName)
        {
            Votes = new HashSet<Vote>();
            ApplicationUserRoles = new HashSet<ApplicationUserRole>();
        }
        public ICollection<Vote> Votes { get; set; }
        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }
    }
}
