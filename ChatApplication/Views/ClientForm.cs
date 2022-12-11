using ChatApplication.Views.MyControl;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChatApplication.Views
{
    public partial class ClientForm : Form
    {
        public static ClientForm instance;
        private EmojiPicker _instance = null;
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
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox chatBox
        {
            get { return textBox; }
            set { textBox = value; }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == string.Empty) return;
            AddMessage(textBox.Text);
            textBox.Text = string.Empty;
        }
        private void AddMessage(string message)
        {
            var bubble = new TextMessage();
            chatContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.message = message;
        }
        private void AddImage(Image image)
        {
            var bubble = new ImageMessage();
            chatContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.image = image;
        }
        private void AddFile(string fileName, byte[] chosenFile)
        {
            var bubble = new FileMessage();
            bubble.chosenFile = chosenFile;
            bubble.fileName = fileName;
            chatContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            string[] imageExtensions = { "jpg", "png", "jpeg" };
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Picture files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                if (imageExtensions.Contains(selectedFileName.Split('.')[1])) {
                    AddImage(new Bitmap(selectedFileName));
                }
                else
                {
                    AddFile(openFileDialog.SafeFileName, File.ReadAllBytes(selectedFileName));
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
    }
}
