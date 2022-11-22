using Microsoft.EntityFrameworkCore;
using Turtel_App.ServerApp.Certification;

namespace Turtel_App.ServerApp.User.Domain
{
    public class UserRepository : InMemoryDbContext
    {
        public UserRepository() : base()
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
