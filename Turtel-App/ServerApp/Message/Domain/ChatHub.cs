using Microsoft.AspNetCore.SignalR;

namespace Turtel_App.ServerApp.Message.Domain;

public class ChatHub : Hub
{

    // This method is called when a client calls the SendMessage method
    public async Task SendMessage(string recipient, string message)
    {
        // Send the message to the specified recipient
        await Clients.User(recipient).SendAsync("ReceiveMessage", Context.User.Identity.Name, message);
        
    }
    
}