using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRooms
{
    public partial class CreateRoom : Form
    {

        private static String responseData = String.Empty;


        public CreateRoom()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            Connect("127.0.0.1", "TestRoom");
        }

        private  static void Connect(String server, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }

        private void UsernameFieldLabel_Click(object sender, EventArgs e)
        {

        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            RoomNameField.Visible = true;
            RoomNameLabel.Visible = true;
            if(RoomNameField.Text != null)
            {

            } else
            {
                return;
            }
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            if(UserNameBox.Text != "")
            { 
                Connect("127.0.0.1", UserNameBox.Text + "'s Room"); 
                if(responseData == "Room created successfully!")
                {
                    Program.CurrentUser = UserNameBox.Text;
                    Program.CurrentRoom = UserNameBox.Text + "'s Room";
                    MainWindow mainwindow = new MainWindow();
                    this.Hide();
                    mainwindow.Show();

                }
                else
                {
                    ErrorLabel.Text = "Username already exists. Please try a different username.";
                }
            }
            else
            {
                ErrorLabel.Text = "Please enter a username.";
                return;
            }
        }
    }
}
