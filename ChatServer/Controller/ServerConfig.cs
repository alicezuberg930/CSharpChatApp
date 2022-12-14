using ChatApplication.Controller;
using ChatApplication.Model;
using ChatApplication.Views;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Entity.Controller
{
    public class ServerConfig
    {
        private IPEndPoint ipe;
        private Socket server;
        private List<Socket> clientList;
        public ServerConfig()
        {
        }
        public void Connect()
        {
            clientList = new List<Socket>();
            ipe = new IPEndPoint(IPAddress.Parse(Utils.GetIPAddress()), 9050);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipe);
            Thread listen = new Thread(() =>
            {
                try
                {
                    MessageBox.Show("Đã tạo kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Thread recieve = new Thread(Recieve);
                        recieve.IsBackground = true;
                        recieve.Start(client);
                    }
                }
                catch
                {
                    ipe = new IPEndPoint(IPAddress.Any, 9050);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        public void Recieve(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] b = new byte[1024 * 5000];
                    client.Receive(b);
                    string message = MessageSerialization.DeserializeText(b);
                    foreach (Socket socket in clientList)
                    {
                        if (socket != null && socket != client)
                            socket.Send(MessageSerialization.SerializeText(message));
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        public void StopServer()
        {
            server.Close();
        }
    }
}
