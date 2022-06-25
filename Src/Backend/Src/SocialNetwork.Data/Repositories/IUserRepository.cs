using SocialNetwork.Infrastructure.Models;

namespace SocialNetwork.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<bool> AddRoleToUser(User user, string role);
        Task<bool> LoginAsync(User user, string password);
        Task<bool> AddUserAsync(User user, string password);
    }
}
