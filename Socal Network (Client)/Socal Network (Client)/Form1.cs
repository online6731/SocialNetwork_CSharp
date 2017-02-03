using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SocialNetwork_Client
{
    public partial class ClientForm : Form
    {
        public static TcpClient clientSocket;
        public static NetworkStream clientStream;
        public static BinaryReader reader;
        public static BinaryWriter writer;
        public static string User_ID; // initializing variables
        public ClientForm()
        {
            InitializeComponent();
        }
        public static void Status(string text)
        {
            // log.Text += text;
            Console.WriteLine(" >>" + text);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            clientSocket = new TcpClient();
            Status("Connecting to " + Convert.ToString(ip.Text) + " on port " + Convert.ToInt16(port.Text));
            clientSocket.Connect(Convert.ToString(ip.Text), Convert.ToInt16(port.Text));
            Status("Just connected to " + Convert.ToString(ip.Text));
            clientStream = clientSocket.GetStream();
            reader = new BinaryReader(clientStream);
            writer = new BinaryWriter(clientStream);
            Status("connect information sent");
        } // biulding a socket and connecting to server
        private void JoinButton_Click(object sender, EventArgs e)
        {
            writer.Write("@opengroup:" +
                "#1" + groups_list.GetItemText(groups_list.SelectedItem) + "1#");
            Status("Sending group name(" + groups_list.GetItemText(groups_list.SelectedItem) + ") to open");
            new ChatForm().Visible = true;
        } // sending group's name to join it
        private void SignupButton_Click(object sender, EventArgs e)
        {
            writer.Write("@newuser:" +
                "#1" + student_no.Text + "1#" +
                "#2" + password.Text + "2#" +
                "#3" + first_name.Text + "3#" +
                "#4" + last_name.Text + "4#");
            Status("sign up information sent");
        } // sending sign up information and trying to sign up
        private void LoginButton_Click(object sender, EventArgs e)
        {
            User_ID = login_ID.Text;
            writer.Write("@login:" +
                "#1" + login_ID.Text + "1#" +
                "#2" + login_pass.Text + "2#");
            string groups, newGroup = "";
            groups = reader.ReadString();
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i] != '|') newGroup += groups[i];
                else
                {
                    groups_list.Items.Add(newGroup);
                    newGroup = "";
                }
            }
            Status("login information sent");
        } // sending login information and trying to login
        private void MakegroupButton_Click(object sender, EventArgs e)
        {
            writer.Write("@makegroup:" +
                "#1" + group_name.Text + "1#" +
                "#2" + group_type.Text + "2#" +
                "#3" + group_describtion.Text + "3#");
            Status("new group information sent");
        }

        private void AddtogroupButton_Click(object sender, EventArgs e)
        {
            writer.Write("@addtogroup:" +
                "#1" + user_id.Text + "1#" +
                "#2" + group_id.Text + "2#");
            Status("user information sent to be added to the group");
        }
    }
}
