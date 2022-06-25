using Microsoft.EntityFrameworkCore;
using SocialNetwork.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SocialNetwork.Infrastructure
{
    public class SocialNetworkContext : IdentityDbContext<User>
    {
        public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Follower> Followers { get; set; }
    }
}
