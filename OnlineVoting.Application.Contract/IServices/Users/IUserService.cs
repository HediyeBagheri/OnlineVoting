using OnlineVoting.Application.Contract.DTOs.Users;

namespace OnlineVoting.Application.Contract.IServices.Users
{
    public interface IUserService
    {
        string Login(LoginDTO dto);
        bool Register(RegisterDTO dto);

    }
}
