namespace ChatApplication.Views.MyControl
{
    partial class EmojiPicker
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
            this.emoji_container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // emoji_container
            // 
            this.emoji_container.AutoScroll = true;
            this.emoji_container.Location = new System.Drawing.Point(0, 0);
            this.emoji_container.Name = "emoji_container";
            this.emoji_container.Size = new System.Drawing.Size(390, 340);
            this.emoji_container.TabIndex = 1;
            // 
            // EmojiPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 340);
            this.Controls.Add(this.emoji_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EmojiPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmojiPicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel emoji_container;
    }
}