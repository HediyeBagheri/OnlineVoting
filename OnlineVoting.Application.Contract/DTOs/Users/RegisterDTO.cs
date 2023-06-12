namespace OnlineVoting.Application.Contract.DTOs.Users
{
    public class RegisterDTO
    {
        public string UserName { get; init; } = null!;
        public string Password { get; init; } = null!;
        public string ConfirmPassword { get; init; } = null!;
    }
}
