using Microsoft.EntityFrameworkCore;

namespace Turtel_App.ServerApp.Message.Domain;

//the database context class is responsible for managing the connection to the database and exposing the database tables as DbSet properties

public class ChatContext : DbContext
{
    // public ChatContext(DbContextOptions<ChatContext> options)
    //     : base(options) {
    // }

    public DbSet<User.Domain.User>? Users { get; set; }
    public DbSet<ChatRoom>? ChatRooms { get; set; }
    public DbSet<Message> Messages { get; set; }
    
    public class Message
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid Receiver { get; set; }
        
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }
    
    
}