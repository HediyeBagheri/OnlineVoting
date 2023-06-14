
using Microsoft.AspNetCore.Identity;
using OnlineVoting.Application.Contract.DTOs.Users;
using OnlineVoting.Application.Contract.IServices.Users;
using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.Model.IdentityModels;

namespace CinamaTicket.Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly ITokenHandler tokenHandler;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPasswordHasher<ApplicationUser> passwordHasher;


        public UserService(ITokenHandler tokenHandler, UserManager<ApplicationUser> userManager,
                           IPasswordHasher<ApplicationUser> passwordHasher)
        {
            this.tokenHandler = tokenHandler;
            this.userManager = userManager;
            this.passwordHasher = passwordHasher;
        }

        public string Login(LoginDTO dto)
        {
            var user = userManager.FindByNameAsync(dto.UserName).GetAwaiter().GetResult();

            if (userManager.CheckPasswordAsync(user, dto.Password).GetAwaiter().GetResult())
            {
                var roles = userManager.GetRolesAsync(user).
                    GetAwaiter().GetResult().ToArray();
                return tokenHandler.GenerateToken(user.Id, roles);
            }

            return "";
        }

        public bool Register(RegisterDTO dto)
        {
            var user = new ApplicationUser(dto.UserName);
            user.PasswordHash = passwordHasher.HashPassword(user, dto.Password);
            var userRole = new ApplicationUserRole()
            {

                RoleId = RoleSeedData.RoleId,
                UserId = user.Id,
            };

            user.ApplicationUserRoles.Add(userRole);
            var SavedUser = userManager.CreateAsync(user).GetAwaiter().GetResult();

            return SavedUser != null;
        }
    }
}
