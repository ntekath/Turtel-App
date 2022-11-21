using Microsoft.EntityFrameworkCore;

namespace Turtel_App.ServerApp.Feedback.Domain
{
    public class FeedbackRepository : ServerApp.Certification.InMemoryDbContext
    {
        public FeedbackRepository() : base()
        {
        }

        public DbSet<Feedback> Feedback { get; set; }

        public Feedback? FindById(Guid id) => 
            (from Feedback f in Feedback
             where f.Id == id select f).FirstOrDefault();
    }
}
