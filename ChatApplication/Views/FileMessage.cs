using ChatApplication.Controller;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ChatApplication.Views
{
    public partial class FileMessage : UserControl
    {
        public byte[] file;
        public FileMessage()
        {
            InitializeComponent();
        }
        public byte[] chosenFile
        {
            get
            {
                return file;
            }
            set
            {
                file = value;
            }
        }
        public string fileName
        {
            get
            {
                return fileLabel.Text;
            }
            set
            {
                fileLabel.Text = value;
                AdjustHeight();
            }
        }
        public Image avatar { get => userAvatar.BackgroundImage; set => userAvatar.BackgroundImage = value; }
        private void AdjustHeight()
        {
            userAvatar.Location = new Point(4, 3);
            msg.Width = Utils.GetTextWidth(fileLabel) + 20;
            container.Width = userAvatar.Left + userAvatar.Width + msg.Left + msg.Width;
            this.Height = container.Height;
            this.Width = container.Width;
        }
        private void container_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
        private void msg_MouseClick(object sender, MouseEventArgs e)
        {
            string[] ex = fileLabel.Text.Split('.');
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ex[1];
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = "c:\\Downloads";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                FileInfo fi = new FileInfo(path);
                using (FileStream fs = fi.OpenWrite())
                {
                    fs.Write(file, 0, file.Length);
                }
            }
        }
    }
}
