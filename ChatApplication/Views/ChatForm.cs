﻿using System;
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
    public partial class ChatForm : Form
    {
        public ChatForm()
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
            AddMessage(textBox.Text);
            textBox.Text = string.Empty;
        }

        private void AddMessage(String message)
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
                    Bitmap image = new Bitmap(selectedFileName);
                    AddImage(image);
                }
                else
                {

                }
            }
        }
    }
}
