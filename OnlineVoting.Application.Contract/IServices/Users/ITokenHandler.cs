using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.IServices.Users
{
    public interface ITokenHandler
    {
        string GenerateToken(string userId, params string[] roles);

        List<Claim> ValidateToken(string token);
    }
}
