using Microsoft.AspNetCore.SignalR;

namespace Turtel_App.ServerApp.Message.Domain;

public class ChatHub : Hub
{
    public void Send(Guid sender, Guid receiver, string message)
        {
            // Add the message to the database.
            using (ChatContext context = new ChatContext())
            {
                ChatContext.Message msg = new ChatContext.Message
                {
                    Text = message,
                    SenderId = sender,
                    Receiver = receiver
                };
                context.Messages.Add(msg);
                context.SaveChanges();
            }

            // Send the message to the recipient.
            Clients.User(receiver).send(sender, message);
        }
}
// Zweiter ansatz
    