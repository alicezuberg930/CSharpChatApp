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
            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            if (IP == null) return;
            clientList = new List<Socket>();
            ipe = new IPEndPoint(IPAddress.Parse(IP), 8000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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
                    ipe = new IPEndPoint(IPAddress.Any, 8000);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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

        private void SendText(Socket client, string text)
        {
            byte[] b = new byte[1024 * 5000];
            b = MessageSerialization.SerializeText(text);
            client.Send(b);
        }

        private void SendImage(Socket client, Bitmap image)
        {
            byte[] b = new byte[1024 * 5000];
            b = MessageSerialization.SerializeImage(image);
            client.Send(b);
        }

        private void SendFile(Socket client, FileModel file)
        {
            byte[] b = new byte[1024 * 5000];
            b = MessageSerialization.SerializeFile(file);
            client.Send(b);
        }
        private void SendEveryoneText(string text)
        {
            foreach (Socket socket in clientList)
            {
                SendText(socket, text);
            }
        }
        private void SendEveryoneImage(Bitmap image)
        {
            foreach (Socket socket in clientList)
            {
                SendImage(socket, image);
            }
        }
        private void SendEveryoneFile(FileModel file)
        {
            foreach (Socket socket in clientList)
            {
                SendFile(socket, file);
            }
        }
    }
}
