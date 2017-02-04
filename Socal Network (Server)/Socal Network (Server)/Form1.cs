using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SocialNetwork_Server
{
    public partial class ServerForm : Form
    {
        public static int counter = 0;
        public static Dictionary<string, client> allusers = new Dictionary<string, client>();
        public static MySqlConnection connection = null;
        public static TcpListener serverSocket = null;
        public static TcpClient clientSocket = null; // biulding objects

        public ServerForm()
        {
            InitializeComponent();
        }

        /********************* Methods **********************/
        public static void Status(string text)
        {
            if (log.InvokeRequired) log.Invoke(new MethodInvoker(() => { log.Text += text + Environment.NewLine; }));
            else log.Text += text + Environment.NewLine;
            Console.WriteLine(" >>" + text);
        } // prints app's logs in log Textbox and console
        public void Connect_Mysql()
        {
            try
            {
                connection = new MySqlConnection(@"server=localhost;userid=SocialNetworkServer;password=ONLINE6731online6731;");
                connection.Open();
                Status("Server connected to database. \n");
                Status("MySQL version : " + connection.ServerVersion + "\n");
            }
            catch (MySqlException ex)
            {
                Status("Server couldn't connect to database. \n");
                Status("Error: " + ex.ToString() + "\n");
            }
        } // connecting to database
        public void StartServer()
        {
            serverSocket = new TcpListener(Convert.ToInt16(port.Text));
            clientSocket = new TcpClient();
            serverSocket.Start();
            Status("Server Started. \n");
            while (counter++ < 10)
            {
                clientSocket = serverSocket.AcceptTcpClient();
                Status("Client No:" + Convert.ToString(counter) + " started! \n");
                new client(clientSocket);
            }
        } // starting server and waiting  for clients to connect
        /****************************************************/



        /******************* Buttons action *****************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
                Status("Database connection is closed. \n");
            }
            if (clientSocket != null && serverSocket != null)
            {
                clientSocket.Close();
                serverSocket.Stop();
                Status("Server closed. \n");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Connect_Mysql();
            new Thread(StartServer).Start();
        }

        /****************************************************/

    }

    public class client
    {
        TcpClient clientSocket;
        NetworkStream networkStream;
        BinaryReader reader;
        BinaryWriter writer;
        string input, User_ID, group;
        bool validUser = false;
        MySqlCommand cmd;
        MySqlDataReader mReader; // initializing variables
        public client(TcpClient newClientSocket)
        {
            clientSocket = newClientSocket;
            networkStream = clientSocket.GetStream();
            reader = new BinaryReader(networkStream);
            writer = new BinaryWriter(networkStream);
            cmd = new MySqlCommand();
            cmd.Connection = ServerForm.connection;
            new Thread(listen).Start();
        } // constructure
        private void listen()
        {
            while (true)
            {
                input = reader.ReadString();
                if (input.StartsWith("@newuser"))
                {
                    addNewUser(input);
                }
                if (input.StartsWith("@login"))
                {
                    loginUser(input);
                }
                if (input.StartsWith("@addpm"))
                {
                    addNewMessege(input);
                }
                if (input.StartsWith("@opengroup"))
                {
                    openGroup(input);
                }
                if (input.StartsWith("@makegroup"))
                {
                    makeGroup(input);
                }
                if (input.StartsWith("@addtogroup"))
                {
                    addToGroup(input);
                }
            }
        } // listening to client and choosing what to do

        /*private void updateClients() {
            for (int i = 0; i < ServerForm.counter; i++)
                ServerForm.client[i].writer.Write("@update:" + group.GetText());
        }*/ // this is for previous version of program that worked with .txt files
        private void addNewMessege(string input)
        {
            cmd.CommandText = "SELECT pm_number FROM groups." + group + " ORDER BY pm_number DESC LIMIT 1";
            ServerForm.Status("SELECT pm_number FROM groups." + group + " ORDER BY pm_number DESC LIMIT 1");
            MySqlDataReader mReader = cmd.ExecuteReader();
            mReader.Read();
            long pmNumber = Convert.ToInt16((mReader.IsDBNull(0) ? "0" : mReader.GetString(0))) + 1;
            mReader.Close();
            string pmSender = readInputCode(input, 1);
            string pmText = readInputCode(input, 2);

            try
            {
                cmd.CommandText = "INSERT INTO groups." + group + "(pm_number, pm_sender, pm_text) VALUES('" + pmNumber + "','" + pmSender + "','" + pmText + "');";
                cmd.ExecuteNonQuery();
                ServerForm.Status("new messege added to database");
                updateClients(input, pmNumber);
            }
            catch (MySqlException ex)
            {
                ServerForm.Status("Server couldn't add new messege to database");
                ServerForm.Status("Error: " + ex.ToString());
            }
        } // adding a new messege to database
        private void addNewUser(string input)
        {
            string NewUserID, NewUserPassword, NewUserFirstName, NewUserLastName;
            NewUserID = readInputCode(input, 1);
            NewUserPassword = readInputCode(input, 2);
            NewUserFirstName = readInputCode(input, 3);
            NewUserLastName = readInputCode(input, 4);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = ServerForm.connection;
                cmd.CommandText = "INSERT INTO informations.users_information(User_ID, First_name, Last_name, password) VALUES('" + NewUserID + "','" + NewUserLastName + "','" + NewUserLastName + "','" + NewUserPassword + "');";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                ServerForm.Status("Server couldn't add new user to database \n");
                ServerForm.Status("Error: " + ex.ToString() + "\n");
            }
            ServerForm.Status("User " + NewUserFirstName + " " + NewUserLastName + " added whit ID: " + NewUserID + " ans Pass: " + NewUserPassword);

        } // adding a new user to database
        private void loginUser(string input)
        {
            User_ID = readInputCode(input, 1);
            string User_pass = readInputCode(input, 2);
            ServerForm.Status("User " + User_ID + " is trying to connect with password " + User_pass);
            cmd.CommandText = "SELECT password FROM informations.users_information WHERE user_id = '" + User_ID + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            if (User_pass == mReader.GetString(0))
            {
                mReader.Close();
                validUser = true;
                ServerForm.allusers.Add(User_ID, this);
                ServerForm.Status("User " + User_ID + " is connected with password " + User_pass);
                sendGroups(User_ID);
            }

        } // logging in an user
        private void sendGroups(string User_ID)
        {
            cmd.CommandText = "SELECT Groups FROM informations.users_information WHERE User_ID = '" + User_ID + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            if (mReader.GetString(0) != null) writer.Write(mReader.GetString(0));
            mReader.Close();
        } // send a user's groups
        public void sendMessege(string messege)
        {
            writer.Write(messege);
        } // send messege to user
        private void openGroup(string input)
        {
            group = readInputCode(input, 1);
            ServerForm.Status("Trying tp send pm of group: " + group);

            for (int i = 1; ; i++)
            {
                ServerForm.Status("SELECT * FROM groups." + group + " WHERE pm_number = '" + Convert.ToString(i) + "'");
                cmd.CommandText = "SELECT * FROM groups." + group + " WHERE pm_number = '" + Convert.ToString(i) + "'";
                mReader = cmd.ExecuteReader();
                if (!mReader.Read()) break;
                ServerForm.Status("Pm sended to mysql");
                writer.Write("@newpm:" +
                "#1" + (mReader.IsDBNull(0) ? "NULL" : mReader.GetString(0)) + "1#" +
                "#2" + (mReader.IsDBNull(1) ? "NULL" : mReader.GetString(1)) + "2#" +
                "#3" + (mReader.IsDBNull(2) ? "NULL" : mReader.GetString(2)) + "3#" +
                "#4" + (mReader.IsDBNull(3) ? "NULL" : mReader.GetString(3)) + "4#" +
                "#5" + group + "5#");
                mReader.Close();
            }
            mReader.Close();
            ServerForm.Status("Pms of group: " + group + "sended");
        } // opening a group for user and sending old conversation to her
        private void updateClients(string input, long pmNumber)
        {
            cmd.CommandText = "SELECT Group_Members FROM informations.groups_information WHERE Group_ID = '" + group + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            string allUsersToUpdate = mReader.GetString(0);
            mReader.Close();
            cmd.CommandText = "SELECT * FROM groups." + group + " WHERE Pm_Number = '" + pmNumber + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            string pmSender = mReader.GetString(1);
            string pmText = mReader.GetString(3);
            mReader.Close();
            string userToUpdate = "";
            for (int i = 0; i < allUsersToUpdate.Length; i++)
            {
                if (allUsersToUpdate[i] != '|')
                {
                    userToUpdate += allUsersToUpdate[i];
                }
                else
                {
                    ServerForm.allusers[userToUpdate].sendMessege("@newpm:" +
                                                                    "#1" + pmNumber + "1#" +
                                                                    "#2" + pmSender + "2#" +
                                                                    "#3" + "NULL" + "3#" +
                                                                    "#4" + pmText + "4#" +
                                                                    "#5" + group + "5#");
                    userToUpdate = "";
                }
            }

        } // sending new pm to group's  clients
        private string readInputCode(string input, int n)
        {
            return input.Substring(input.IndexOf("#" + Convert.ToString(n)) + 2, input.IndexOf(Convert.ToString(n) + "#") - input.IndexOf("#" + Convert.ToString(n)) - 2);
        } // encoding input messege and getting information
        private void makeGroup(string input)
        {
            string group_name = readInputCode(input, 1);
            string group_type = readInputCode(input, 2);
            string group_describtion = readInputCode(input, 3);
            cmd.CommandText = "CREATE TABLE groups. " + group_name + 
                            "(" +
                                "pm_number INT," + 
                                "pm_sender VARCHAR(45)," +
                                "pm_datetime DATE," +
                                "pm_text TEXT," +
                                "PRIMARY KEY (pm_number)" +
                            ")" ;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO groups." + group_name + " (pm_number,pm_sender,pm_text) VALUES('1' , 'Server' , 'group starts!')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO informations.groups_information (group_id,group_name,group_type,group_describtion,group_members) VALUES('" + group_name + "' , '" + group_name + "' , '" + group_type + "' , '" + group_describtion + "' , '" + User_ID + '|' + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT groups FROM informations.users_information WHERE user_id = '" + User_ID + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            string user_groups = mReader.GetString(0) + group_name + "|";
            mReader.Close();
            cmd.CommandText = "UPDATE informations.users_information SET groups ='" + user_groups + "' WHERE user_id = '" + User_ID + "'";
            cmd.ExecuteNonQuery();
        } // adding a new group
        private void addToGroup(string input)
        {
            string user_id = readInputCode(input, 1);
            string group_id = readInputCode(input, 2);
            cmd.CommandText = "SELECT groups FROM informations.users_information WHERE user_id = '" + user_id + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            string user_groups = (mReader.IsDBNull(0) ? "" : mReader.GetString(0)) + group_id + "|";
            mReader.Close();
            cmd.CommandText = "UPDATE informations.users_information SET groups ='" + user_groups + "' WHERE user_id = '" + user_id + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT group_members FROM informations.groups_information WHERE group_id = '" + group_id + "'";
            mReader = cmd.ExecuteReader();
            mReader.Read();
            string group_members = (mReader.IsDBNull(0) ? "" : mReader.GetString(0)) + user_id + "|";
            mReader.Close();
            cmd.CommandText = "UPDATE informations.groups_information SET group_members ='" + group_members + "' WHERE group_id = '" + group_id + "'";
            cmd.ExecuteNonQuery();
        } // adding a user to a group

    }
}
