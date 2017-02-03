using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace SocialNetwork_Client
{
    public partial class ChatForm : Form
    {
        public static TcpClient clientSocket;
        public static NetworkStream clientStream;
        public static BinaryReader reader;
        public static BinaryWriter writer;
        public static string User_ID; // initializing variables
        public ChatForm()
        {
            InitializeComponent();
            clientSocket = ClientForm.clientSocket;
            clientStream = ClientForm.clientStream;
            reader = ClientForm.reader;
            writer = ClientForm.writer;
            User_ID = ClientForm.User_ID;
            new Thread(listener).Start();
        }

        public void listener()
        {
            while (true)
            {
                string input = reader.ReadString();
                Console.WriteLine(input);
                if (input.StartsWith("@newpm"))
                {
                    newPm(input);
                }

            }
        }
        public void newPm(string input)
        {
            string pmNumber = readInputCode(input, 1);
            string pmSender = readInputCode(input, 2);
            string pmDateTime = readInputCode(input, 3);
            string pmText = readInputCode(input, 4);
            string pmGroup = readInputCode(input, 5);
            addNewPm(pmSender + ": " + pmText + "\n");
        }
        public void addNewPm(string text)
        {
            if (allmesseges.InvokeRequired) allmesseges.Invoke(new MethodInvoker(() => { allmesseges.Text += text + Environment.NewLine; }));
            else allmesseges.Text += text + Environment.NewLine;
        }
        private string readInputCode(string input, int n)
        {
            return input.Substring(input.IndexOf("#" + Convert.ToString(n)) + 2, input.IndexOf(Convert.ToString(n) + "#") - input.IndexOf("#" + Convert.ToString(n)) - 2);
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            writer.Write("@addpm:" +
                "#1" + User_ID + "1#" +
                "#2" + messege.Text + "2#");
            messege.Clear();
        }

    }
}
