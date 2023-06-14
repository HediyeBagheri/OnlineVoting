using System.Security.Claims;

namespace OnlineVoting.Application.Contract.IServices.Users
{
    public interface ITokenHandler
    {
        string GenerateToken(string userId, params string[] roles);

        List<Claim> ValidateToken(string token);
    }
}
