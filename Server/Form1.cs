using ManagerCinema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        DatabaseConnect Database = new DatabaseConnect();
        IPEndPoint iPAddress;
        Socket server;
        Socket client;
        List<Socket> clientList;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        void Connect()
        {
            clientList = new List<Socket>();

            iPAddress = new IPEndPoint(IPAddress.Parse(Const.IP), 9999);
     
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            // wait ip
            server.Bind(iPAddress);

            Thread listener = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();

                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                        lbConnect.Text = "Connected: " + clientList.Count();
                    }
                }
                catch
                {
                    iPAddress = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listener.IsBackground = true;
            listener.Start();

        }

        void Close()
        {
            server.Close();
        }

        void Receive(object obj)
        {

            client = obj as Socket;

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Reserialize(data);
                    RecevieRequest(message);
                }
            }
            catch
            {
                CloseClient();
            }
        }

        public void CloseClient()
        {
            clientList.Remove(client);
            lbConnect.Text = "Connected: " + clientList.Count();
            client.Close();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }

        object Reserialize(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // case load data
        public void RecevieRequest(string request)
        {
            switch (request)
            {
                case CodeData.TICKET_LOAD_ALL:
                    DataTable dataTable = new DataTable();
                    dataTable = Database.ExecuteQueryDataSet(CodeData.TICKET_LOAD_ALL, CommandType.Text);
                    Send(dataTable);
                    break;
                case CodeData.CLOSE:
                    CloseClient();
                    break;
            }
        }

        void Send(object obj)
        {
            foreach (Socket item in clientList)
            {
                item.Send(Serialize(obj));
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
