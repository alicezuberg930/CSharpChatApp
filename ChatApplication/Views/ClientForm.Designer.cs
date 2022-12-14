namespace ChatApplication.Views
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chatContainer = new System.Windows.Forms.Panel();
            this.emojiButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.imageButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.sendButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.textBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.messageContainer = new System.Windows.Forms.Panel();
            this.messageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 565);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(151, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 55);
            this.panel2.TabIndex = 1;
            // 
            // chatContainer
            // 
            this.chatContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.chatContainer.Location = new System.Drawing.Point(151, 55);
            this.chatContainer.Name = "chatContainer";
            this.chatContainer.Size = new System.Drawing.Size(1050, 452);
            this.chatContainer.TabIndex = 2;
            // 
            // emojiButton
            // 
            this.emojiButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emojiButton.BackgroundImage")));
            this.emojiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emojiButton.BorderRadius = 15;
            this.emojiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojiButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.emojiButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.emojiButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.emojiButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.emojiButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.emojiButton.FillColor = System.Drawing.Color.Empty;
            this.emojiButton.FillColor2 = System.Drawing.Color.Empty;
            this.emojiButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emojiButton.ForeColor = System.Drawing.Color.White;
            this.emojiButton.Location = new System.Drawing.Point(105, 10);
            this.emojiButton.Name = "emojiButton";
            this.emojiButton.Size = new System.Drawing.Size(40, 40);
            this.emojiButton.TabIndex = 7;
            this.emojiButton.Click += new System.EventHandler(this.emojiButton_Click);
            // 
            // imageButton
            // 
            this.imageButton.BackColor = System.Drawing.Color.Transparent;
            this.imageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageButton.BackgroundImage")));
            this.imageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButton.BorderColor = System.Drawing.Color.Empty;
            this.imageButton.BorderRadius = 15;
            this.imageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.imageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.imageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.imageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.imageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.imageButton.FillColor = System.Drawing.Color.Empty;
            this.imageButton.FillColor2 = System.Drawing.Color.Empty;
            this.imageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imageButton.ForeColor = System.Drawing.Color.White;
            this.imageButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.imageButton.Location = new System.Drawing.Point(151, 10);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(40, 40);
            this.imageButton.TabIndex = 6;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendButton.BackgroundImage")));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sendButton.BorderColor = System.Drawing.Color.Transparent;
            this.sendButton.BorderRadius = 15;
            this.sendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendButton.FillColor = System.Drawing.Color.Empty;
            this.sendButton.FillColor2 = System.Drawing.Color.Empty;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.sendButton.Location = new System.Drawing.Point(902, 10);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(40, 40);
            this.sendButton.TabIndex = 4;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // textBox
            // 
            this.textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.textBox.BorderRadius = 15;
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultText = "Nhập tin nhắn";
            this.textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Location = new System.Drawing.Point(206, 10);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderText = "";
            this.textBox.SelectedText = "";
            this.textBox.Size = new System.Drawing.Size(680, 40);
            this.textBox.TabIndex = 3;
            // 
            // messageContainer
            // 
            this.messageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.messageContainer.Controls.Add(this.emojiButton);
            this.messageContainer.Controls.Add(this.textBox);
            this.messageContainer.Controls.Add(this.sendButton);
            this.messageContainer.Controls.Add(this.imageButton);
            this.messageContainer.Location = new System.Drawing.Point(151, 505);
            this.messageContainer.Name = "messageContainer";
            this.messageContainer.Size = new System.Drawing.Size(1050, 60);
            this.messageContainer.TabIndex = 15;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1182, 565);
            this.Controls.Add(this.messageContainer);
            this.Controls.Add(this.chatContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.messageContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel chatContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton sendButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton emojiButton;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton imageButton;
        private System.Windows.Forms.Panel messageContainer;
    }
}