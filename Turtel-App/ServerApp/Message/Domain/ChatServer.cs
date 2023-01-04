using System.Net;
using System.Net.Sockets;

namespace Turtel_App.ServerApp.Message.Domain;

public class ChatServer
{
    class Program
    {
        static void NotMain(string[] args)
        {
            // Set the IP address and port number for the server.
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 9000;

            // Create a new TcpListener object.
            TcpListener listener = new TcpListener(ipAddress, port);

            // Start listening for incoming connections.
            listener.Start();

            //Console.WriteLine("Server is listening for connections on port " + port + "...");

            // Wait for a client to connect.
            TcpClient client = listener.AcceptTcpClient();

            //Console.WriteLine("A client has connected.");

            // Get the NetworkStream object for the client.
            NetworkStream stream = client.GetStream();

            // Use the StreamReader and StreamWriter objects to read from and write to the NetworkStream.
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);

            // Send a message to the client.
            writer.WriteLine("Welcome to the chat app! Please enter your name:");
            writer.Flush();

            // Read the client's name.
            string clientName = reader.ReadLine();

            // Send a message to the client.
            writer.WriteLine("Hello, " + clientName + "! You are now connected to the chat server.");
            writer.Flush();

            // // Create a new instance of the ChatContext.
            // ChatContext context = new ChatContext();

            // Enter a loop to read and write messages with the client.
            while (true)
            {
                // Read a message from the client.
                string message = reader.ReadLine();

                // Read the recipient's username from the client.
                string recipient = reader.ReadLine();

                // Create a new Message entity and add it to the database.
                using (ChatContext context = new ChatContext())
                {
                    ChatContext.Message msg = new ChatContext.Message
                    {
                        Text = message,
                        SenderId = Guid.Parse(senderGuid), ///hier werden die ID von Sender und Empfänger benötigt diese müssen übergeben werden wenn der button ausgelöst wird
                        Receiver = Guid.Parse(receiverGuid)
                    };
                    context.Messages.Add(msg);
                    context.SaveChanges();
                }
            }
        }
    }
}
