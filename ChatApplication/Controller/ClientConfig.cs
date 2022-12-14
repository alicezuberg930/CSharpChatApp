using ChatApplication.Controller;
using System.Net.Sockets;
using System.Net;
using ChatApplication.Model;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using ChatApplication.Views;
using System;

namespace Entity.Controller
{
    public class ClientConfig 
    {
        private IPEndPoint ipe;
        private Socket client;
        private ClientForm clientForm;
        public static int state = 1;
        private Utils utils;
        private int message_type;
        public ClientConfig(ClientForm clientForm)
        {
            this.clientForm = clientForm;
            utils = new Utils();
        }

        public void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse(Utils.GetIPAddress()), 9050);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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
            try
            {
                while (true)
                {
                    byte[] b = new byte[1024 * 5000];
                    client.Receive(b);
                    string message = MessageSerialization.DeserializeText(b);
                    Utils.IncomingMessage(message, clientForm.chatPanel);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void StopClient()
        {
            client.Close();
        }

        public void SendText(string text)
        {
            message_type = 1;
            client.Send(MessageSerialization.SerializeText(text));
            Utils.IncomingMessage(text, clientForm.chatPanel);
        }

        public void SendImage(Bitmap image)
        {
            client.Send(MessageSerialization.SerializeImage(image));
            Utils.IncomingImage(image, clientForm.chatPanel);
        }

        public void SendFile(FileModel file)
        {
            client.Send(MessageSerialization.SerializeFile(file));
            Utils.IncomingFile(file.file_name, file.file_content, clientForm.chatPanel);
        }
    }
}
