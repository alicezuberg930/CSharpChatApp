using ChatApplication.Controller;
using System.Net.Sockets;
using System.Net;
using ChatApplication.Model;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using ChatApplication.Views;

namespace Entity.Controller
{
    public class ClientConfig 
    {
        private IPEndPoint ipe;
        private Socket client;
        private ClientForm clientForm;
        public static int state = 1;
        private Utils utils;

        public ClientConfig(ClientForm clientForm)
        {
            this.clientForm = clientForm;
            utils = new Utils();
        }

        public void Connect()
        {
            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            if (IP == null) return;
            ipe = new IPEndPoint(IPAddress.Parse(IP), int.Parse("8000"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ipe);
                MessageBox.Show("Kết nối đến server thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                state = 0;
                return;
            }
            Thread listen = new Thread(Recieve);
            listen.IsBackground = true;
            listen.Start();
        }

        public void Recieve()
        {
            //try
            //{
                while (true)
                { 
                    byte[] b = new byte[1024 * 5000];
                    client.Receive(b);
                    string message = MessageSerialization.DeserializeText(b);
                Utils.IncomingMessage(message, clientForm.chatPanel);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Không nhận được tin nhắn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void StopClient()
        {
            client.Close();
        }
        public void SendText(string text)
        {
            byte[] b = new byte[1024 * 5000];
            b = MessageSerialization.SerializeText(text);
            client.Send(b);
            Utils.IncomingMessage(text, clientForm.chatPanel);
        }

        public void SendImage(Bitmap image)
        {
            byte[] b = new byte[1024 * 5000];
            b = MessageSerialization.SerializeImage(image);
            client.Send(b);
            Utils.IncomingImage(image, clientForm.chatPanel);
        }

        public void SendFile(FileModel file)
        {
            client.Send(MessageSerialization.SerializeFile(file));
            Utils.IncomingFile(file.file_name, file.file_content, clientForm.chatPanel);
        }
    }
}
