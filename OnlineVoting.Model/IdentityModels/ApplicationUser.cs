using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
