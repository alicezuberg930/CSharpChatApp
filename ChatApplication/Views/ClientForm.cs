using ChatApplication.Views.MyControl;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ChatApplication.Controller;
using Entity.Controller;
using ChatApplication.Model;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace ChatApplication.Views
{
    public partial class ClientForm : Form
    {
        public static ClientForm instance;
        private EmojiPicker _instance = null;
        public ClientConfig cc;
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox chatBox
        {
            get { return textBox; }
            set { textBox = value; }
        }
        public Panel chatPanel
        {
            get { return chatContainer; }
            set { chatContainer = value; }
        }
        public static ClientForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClientForm();
                return instance;
            }
        }
        public ClientForm()
        {
            InitializeComponent();
            chatContainer.AutoScroll = false;
            chatContainer.HorizontalScroll.Enabled = false;
            chatContainer.HorizontalScroll.Visible = false;
            chatContainer.HorizontalScroll.Maximum = 0;
            chatContainer.AutoScroll = true;
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == string.Empty) return;
            cc.SendText(textBox.Text);
            //Utils.IncomingMessage(textBox.Text,chatContainer);
            textBox.Text = string.Empty;
        }
        private void imageButton_Click(object sender, EventArgs e)
        {
            string[] imageExtensions = { "jpg", "png", "jpeg" };
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                if (imageExtensions.Contains(selectedFileName.Split('.')[1])) {
                    cc.SendImage(new Bitmap(selectedFileName));
                    //Utils.IncomingImage(new Bitmap(selectedFileName), chatContainer);
                }
                else
                {
                    cc.SendFile(new FileModel(openFileDialog.SafeFileName, File.ReadAllBytes(selectedFileName))); 
                    //Utils.IncomingFile(openFileDialog.SafeFileName, File.ReadAllBytes(selectedFileName), chatContainer);
                } 
            }
        }
        private void emojiButton_Click(object sender, EventArgs e)
        {
            if (_instance == null)
            {
                _instance = new EmojiPicker(this);
                _instance.Show();
            }
            else
            {
                _instance.Close();
                _instance = null;
            }
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            cc = new ClientConfig(this);
            CheckForIllegalCrossThreadCalls = false;
            //Connect();
            cc.Connect();
            if (ClientConfig.state == 0)
            {
                Close();
            }
        }
        public void IncomingMessage(string message)
        {
            chatContainer.Invoke((MethodInvoker)delegate ()
            {
                var bubble = new TextMessage();
                chatContainer.Controls.Add(bubble);
                bubble.BringToFront();
                bubble.Dock = DockStyle.Top;
                bubble.message = message;
            });
        }
    }
}
