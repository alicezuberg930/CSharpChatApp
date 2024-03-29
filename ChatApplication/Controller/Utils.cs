﻿using ChatApplication.Views.MyControl;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ChatApplication.Controller
{
    public class Utils
    {
        public Utils() { }
        public static int GetTextHeight(Label l)
        {
            using (Graphics g = l.CreateGraphics())
            {
                SizeF size = g.MeasureString(l.Text, l.Font, 500);
                return (int)Math.Ceiling(size.Height);
            }
        }
        public static int GetTextWidth(Label l)
        {
            using (Graphics g = l.CreateGraphics())
            {
                SizeF size = g.MeasureString(l.Text, l.Font, 500);
                return (int)Math.Ceiling(size.Width);
            }
        }
        public static void IncomingMessage(string message, Panel panel)
        {
            panel.Invoke((MethodInvoker)delegate ()
            {
                var bubble = new TextMessage();
                panel.Controls.Add(bubble);
                bubble.BringToFront();
                bubble.Dock = DockStyle.Top;
                bubble.message = message;
            });
        }
        public static void IncomingImage(Image image, Panel panel)
        {
            panel.Invoke((MethodInvoker)delegate ()
            {
                var bubble = new ImageMessage();
                panel.Controls.Add(bubble);
                bubble.BringToFront();
                bubble.Dock = DockStyle.Top;
                bubble.image = image;
            });
        }
        public static void IncomingFile(string fileName, byte[] chosenFile, Panel panel)
        {
            panel.Invoke((MethodInvoker)delegate ()
            {
                var bubble = new FileMessage();
                bubble.chosenFile = chosenFile;
                bubble.fileName = fileName;
                panel.Controls.Add(bubble);
                bubble.BringToFront();
                bubble.Dock = DockStyle.Top;
            });
        }

        public static string GetIPAddress()
        {
            foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    if (ni.Name.Equals("Wi-Fi"))
                    {
                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                return ip.Address.ToString();
                            }
                        }
                    }
                }
            }
            return "127.0.0.1";
        }
    }
}
