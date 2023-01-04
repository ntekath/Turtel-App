// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
// using Turtel_App.ServerApp.Certification;
//
// namespace Turtel_App.ServerApp.Message.Domain
// {
//     public class MessageRepository : InMemoryDbContext
//     {
//         public MessageRepository() : base()
//         {
//         }
//
//         public DbSet<Message> Messages { get; set; }
//
//         public Message? FindByGuid(Guid guid) =>
//             (from Message Message in Messages
//                 where Message.Id == guid
//                 select Message).FirstOrDefault();
//     }
// }
