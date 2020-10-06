using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ChatRoomsServer
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            ServerStart();
        }


        public static void ServerStart()
        {
            TcpListener server;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.WriteLine($"Server Started on {localAddr}:{ port}.");
                    Console.WriteLine("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);
                        string response = "";
                        // Process the data sent by the client.
                        if (data.EndsWith("Room"))
                        {
                            string FileToWrite = (@"C:\Users\" + Environment.UserName + @"\Desktop\TestRooms\" + data + ".txt");
                            if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\TestRooms\"))
                            {
                                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Desktop\TestRooms\");
                            }
                            if (!File.Exists(FileToWrite))
                            {
                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileToWrite, true))
                                {
                                    file.WriteLine("Welcome to the chatroom!");
                                    response = "Room created successfully!";
                                }
                            } else
                            {

                                response = "Room already exists.";
                            }
                        }

                            
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(response);

                        // Send back a response.
                        
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", response);
                        

                    }

                    byte[] newmsg = System.Text.Encoding.ASCII.GetBytes(data);
                    stream.Write(newmsg, 0, newmsg.Length);

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                //server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}
