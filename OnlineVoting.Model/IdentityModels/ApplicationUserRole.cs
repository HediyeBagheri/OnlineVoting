using OnlineVoting.Model.IdentityModels;
using Microsoft.AspNetCore.Identity;

public class ApplicationUserRole : IdentityUserRole<string>
{
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public string RoleId { get; set; }
    public ApplicationRole Role { get; set; }
}
