using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Application.Contract.DTOs.Users;

namespace OnlineVoting.Application.Contract.IServices.Users
{
    public interface IUserService
    {
        string Login(LoginDTO dto);
        bool Register(RegisterDTO dto);
         
    }
}
