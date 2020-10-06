using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRooms
{
    public partial class MainWindow : Form
    {
        private String MessageToBeSent;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (ChatInputBox.Text != "")
            {
                MessageToBeSent = "[" + DateTime.Now.ToString() + "] " + Program.CurrentUser + ": " + ChatInputBox.Text + "\n" + Program.CurrentRoom;
                MessageHandler.SyncMessages("127.0.0.1", MessageToBeSent);
            }
        }
    }
}
