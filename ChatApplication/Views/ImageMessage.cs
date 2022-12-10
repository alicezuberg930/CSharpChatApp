using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ChatApplication.Views
{
    public partial class ImageMessage : UserControl
    {
        public ImageMessage()
        {
            InitializeComponent();
        }
        public Image image
        {
            get
            {
                return imageBox.Image;
            }
            set
            {
                imageBox.Image = value;
                AdjustHeight();
            }
        }
        public Image avatar { get => userAvatar.BackgroundImage; set => userAvatar.BackgroundImage = value; }
        private void AdjustImageResolution()
        {
            int width = image.Width;
            int height = image.Height;
            if (width > height)
            {
                while (width >= 500)
                {
                    width /= 2;
                    height /= 2;
                }
            }
            else if (width < height)
            {
                while (height >= 400)
                {
                    width /= 2;
                    height /= 2;
                }
            }
            imageBox.Width = width;
            imageBox.Height = height;
        }
        private void AdjustHeight()
        {
            AdjustImageResolution();
            userAvatar.Location = new Point(4, 3);
            container.Width = userAvatar.Left + userAvatar.Width + imageBox.Left + imageBox.Width;
            container.Height = imageBox.Height;
            this.Height = container.Height;
            this.Width = container.Width;
        }
        private void imageBox_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = "c:\\Downloads";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imageBox.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
