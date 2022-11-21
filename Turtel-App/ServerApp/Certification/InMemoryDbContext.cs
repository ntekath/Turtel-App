using Microsoft.EntityFrameworkCore;

namespace Turtel_App.ServerApp.Certification
{

    public abstract class InMemoryDbContext : DbContext
    {
        public string DbPath { get; }

        public InMemoryDbContext() : base()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, this.GetType().Name + ".db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseInMemoryDatabase($"Data Source={DbPath}");
    }
    
}
