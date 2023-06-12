using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.DTOs.Users
{
    public class LoginDTO
    {
        public string UserName { get; init; } 
        public string Password { get; init; } 
    }
}
