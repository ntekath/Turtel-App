namespace Turtel_App.ServerApp.Message.Domain;

public class HubConnection
{
    private HubConnection hubConnection;

    public async Task ConnectAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl("https://yourserver.com/chathub")
            .Build();

        // Start the connection
        await hubConnection.StartAsync();
    }

// Send a message to the server
    private async void SendMessage(string message)
    {
        try
        {
            // Call the SendMessage method on the server
            await hubConnection.InvokeAsync("SendMessage", message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

// Receive a message from the server
    private async void ReceiveMessage(string sender, string message)
    {
        // Display the message in the chat window
        chatWindow.AppendText($"{sender}: {message}\n");
    }
    
}

/////// das läuft auf dem server //////////////////////////////
// using System;
// using System.IO;
// using System.Net;
// using System.Net.Sockets;
//
// namespace ChatApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Set the IP address and port number for the server.
//             IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
//             int port = 9000;
//
//             // Create a new TcpListener object.
//             TcpListener listener = new TcpListener(ipAddress, port);
//
//             // Start listening for incoming connections.
//             listener.Start();
//
//             Console.WriteLine("Server is listening for connections on port " + port + "...");
//
//             // Wait for a client to connect.
//             TcpClient client = listener.AcceptTcpClient();
//
//             Console.WriteLine("A client has connected.");
//
//             // Get the NetworkStream object for the client.
//             NetworkStream stream = client.GetStream();
//
//             // Use the StreamReader and StreamWriter objects to read from and write to the NetworkStream.
//             StreamReader reader = new StreamReader(stream);
//             StreamWriter writer = new StreamWriter(stream);
//
//             // Send a message to the client.
//             writer.WriteLine("Welcome to the chat app! Please enter your name:");
//             writer.Flush();
//
//             // Read the client's name.
//             string clientName = reader.ReadLine();
//
//             // Send a message to the client.
//             writer.WriteLine("Hello, " + clientName + "! You are now connected to the chat server.");
//             writer.Flush();
//
//             // Enter a loop to read and write messages with the client.
//             while (true)
//             {
//                 // Read a message from the client.
//                 string message = reader.ReadLine();
//
//                 // Print the message to the console.
//                 Console.WriteLine(clientName + ": " + message);
//
//                 // Write a message back to the client.
//                 writer.WriteLine("You said: " + message);
//                 writer.Flush();
//             }
//         }
//     }
// }
