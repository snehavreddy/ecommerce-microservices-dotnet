using AuthService.Models;

namespace AuthService.Services.Interface
{
    public interface IUserService
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User> CreateAsync(User user);
    }
}
