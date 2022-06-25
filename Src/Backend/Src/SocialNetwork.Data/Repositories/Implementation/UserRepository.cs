using Microsoft.AspNetCore.Identity;
using SocialNetwork.Infrastructure.Models;

namespace SocialNetwork.Infrastructure.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialNetworkContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserRepository(SocialNetworkContext context, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> LoginAsync(User user, string password)
        {
            SignInResult login = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            return login.Succeeded;
        }

        public async Task<bool> AddUserAsync(User user, string password)
        {
            IdentityResult add = await _userManager.CreateAsync(user, password);
            return add.Succeeded;
        }

        public async Task<bool> AddRoleToUser(User user, string role)
        {
            IdentityResult add = await _userManager.AddToRoleAsync(user, role);
            return add.Succeeded;
        }
    }
}
