using ChatApplication.Controller;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApplication.Views.MyControl
{
    public partial class EmojiPicker : Form
    {
        public ChatForm cf;
        public EmojiPicker(ChatForm cf)
        {
            InitializeComponent();
            CreateEmojis();
            this.cf = cf;
        }
        public void CreateEmojis()
        {
            Size size = new Size(45, 45);
            int columns = 6;
            for (int i = 0; i < Emoji.my_emojis.Length; i++)
            {
                int curentColumn = i % columns;
                int currentRow = i / columns;
                int curentX = 0 + curentColumn * size.Width;
                int curentY = 0 + currentRow * size.Height;
                Label emoji = new Label
                {
                    Name = "emoji_" + i,
                    Size = size,
                    Location = new Point(curentX, curentY),
                    BorderStyle = BorderStyle.None,
                    Visible = true,
                    BackColor = Color.White,
                    Cursor = Cursors.Hand,
                    Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Text = Emoji.my_emojis[i]
                };
                emoji.Click += (sender, e) =>
                {
                    cf.chatBox.Text += emoji.Text;
                };
                emoji_container.Controls.Add(emoji);
            }
        }
    }
}