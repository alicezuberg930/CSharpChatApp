using System;
using System.Windows.Forms;
using Entity.Controller;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        ServerConfig sc;
        public Form1()
        {
            InitializeComponent();
            sc = new ServerConfig();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            sc.Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            sc.StopServer();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
