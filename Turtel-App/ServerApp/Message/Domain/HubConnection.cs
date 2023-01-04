
// ich glaube das ist nutzlos !!!!!!!!!!!
// namespace Turtel_App.ServerApp.Message.Domain;
//
// public class HubConnection
// {
//     private HubConnection hubConnection;
//
//     public async Task ConnectAsync()
//     {
//         hubConnection = new HubConnectionBuilder()
//             .WithUrl("https://yourserver.com/chathub")
//             .Build();
//
//         // Start the connection
//         await hubConnection.StartAsync();
//     }
//
// // Send a message to the server
//     private async void SendMessage(string message)
//     {
//         try
//         {
//             // Call the SendMessage method on the server
//             await hubConnection.InvokeAsync("SendMessage", message);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
//
// // Receive a message from the server
//     private async void ReceiveMessage(string sender, string message)
//     {
//         // Display the message in the chat window
//         chatWindow.AppendText($"{sender}: {message}\n");
//     }
//     
// }
//
// /