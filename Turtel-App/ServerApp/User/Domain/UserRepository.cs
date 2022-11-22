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

        public User? FindByGuid(Guid guid) =>
            (from User user in Users
             where user.Id == guid
             select user).FirstOrDefault();
    }
}
