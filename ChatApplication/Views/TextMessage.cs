﻿using ChatApplication.Controller;
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
    public partial class TextMessage : UserControl
    {
        public TextMessage()
        {
            InitializeComponent();
        }
        public string message {
            get
            {
                return messageLabel.Text;
            }
            set
            {
                messageLabel.Text = value;
                AdjustHeight();
            }
        }
        public Image avatar { get => userAvatar.BackgroundImage; set => userAvatar.BackgroundImage = value; }   

        private void AdjustHeight()
        {
            userAvatar.Location = new Point(4, 3);
            msg.Width = Utils.GetTextWidth(messageLabel) + 20;
            container.Width = userAvatar.Left + userAvatar.Width + msg.Left + msg.Width;
            this.Height = container.Height;
            this.Width = container.Width;
        }

        private void container_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
