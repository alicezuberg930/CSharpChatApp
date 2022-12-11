using System.Net;
using System.Net.Sockets;

namespace CORE.Controller
{
    internal class ServerConfig
    {
        private IPEndPoint ipe;
        private Socket server;
        private List<Socket> clientList;

        private void Connect()
        {
            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            if (IP == null) return;
            clientList = new List<Socket>();
            ipe = new IPEndPoint(IPAddress.Parse(IP), int.Parse("8000"));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ipe);
            Thread listen = new Thread(() => 
            {
                try
                {
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
                    ipe = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        private void Recieve(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                                 }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        private void Send(Socket client)
        {
           
        }
    }
}
