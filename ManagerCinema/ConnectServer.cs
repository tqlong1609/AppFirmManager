using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public class ConnectServer
    {
        private delegate void SafeCallDelegate(object data);
        private static ConnectServer instance;
        IPEndPoint iPAddress;
        Socket client;
        DataGridView dgvData;
        UserControl uc;
        PictureBox pbx;

        private string codeData;

        public static ConnectServer getInstance()
        {
            if(instance == null)
            {
                instance = new ConnectServer();
            }
            return instance;
        }

        private ConnectServer()
        {
            Connect();
        }

        public void loadDataFromServer(DataGridView dgvData, UserControl uc,string codeData , PictureBox pbx)
        {
            this.dgvData = dgvData;
            this.uc = uc;
            this.pbx = pbx;
            this.codeData = codeData;
            pbx.Click += Pbx_Click;
        }

        public void NotificationCloseServer()
        {
            codeData = CodeData.CLOSE;
            Send();
        }

        private void Pbx_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void SendData(object sender, EventArgs e)
        {
            Send();
        }

        private void Close()
        {
            client.Close();
        }
        private byte[] Serialize(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }

        private object Reserialize(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }
        public void Send()
        {
            client.Send(Serialize(codeData));
        }
        private static class ThreadHelperClass
        {
            delegate void setValueCallBack(UserControl f, DataGridView ctrl, DataTable value);

            public static void setValue(UserControl f, DataGridView ctrl, DataTable value)
            {
                if (ctrl.InvokeRequired)
                {
                    setValueCallBack d = new setValueCallBack(setValue);
                    f.Invoke(d, new object[] { f, ctrl, value });
                }
                else
                {
                    ctrl.DataSource = value;
                }
            }

        }
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    DataTable message = (DataTable)Reserialize(data);
                    ThreadHelperClass.setValue(uc, dgvData, message);
                }
            }
            catch
            {
                Close();
            }
        }
        private bool Connect()
        {
            iPAddress = new IPEndPoint(IPAddress.Parse(Const.IP), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(iPAddress);
            }
            catch
            {
                return false ;
            }

            Thread listener = new Thread(new ThreadStart(Receive));
            listener.Start();
            return true;
        }
    }
}
