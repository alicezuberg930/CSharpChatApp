using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.Views
{
    public partial class FileMessage : UserControl
    {
        public FileMessage()
        {
            InitializeComponent();
        }
        public string file
        {
            get
            {
                return fileRichTextBox.Text;
            }
            set
            {
                fileRichTextBox.Text = value;
                AdjustHeight();
            }
        }
        public Image avatar { get => userAvatar.BackgroundImage; set => userAvatar.BackgroundImage = value; }

        private void AdjustHeight()
        {
            userAvatar.Location = new Point(4, 3);
            msg.Width = fileRichTextBox.Width;
            container.Width = userAvatar.Left + userAvatar.Width + msg.Left + msg.Width + 20;
            this.Height = container.Height;
            this.Width = container.Width;
        }

        private void container_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
        private void fileRichTextBox_Click(object sender, EventArgs e)
        {

        }
    }
    //   richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
}
