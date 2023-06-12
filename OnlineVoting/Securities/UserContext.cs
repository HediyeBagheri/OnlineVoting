using OnlineVoting.Application.Contract.IServices.Users;

namespace OnlineVoting.EndPoint.Securities
{
    public class UserContext : IUserContext
    {
        public string UserId { get; set; }
    }
}
