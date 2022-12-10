namespace ChatApplication.Views
{
    partial class FileMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMessage));
            this.userAvatar = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.container = new DevExpress.XtraEditors.PanelControl();
            this.fileRichTextBox = new System.Windows.Forms.RichTextBox();
            this.msg = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.SuspendLayout();
            this.msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // userAvatar
            // 
            this.userAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userAvatar.BackgroundImage")));
            this.userAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userAvatar.BorderRadius = 15;
            this.userAvatar.Location = new System.Drawing.Point(8, 5);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(50, 50);
            this.userAvatar.TabIndex = 1;
            // 
            // container
            // 
            this.container.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.container.Appearance.Options.UseBackColor = true;
            this.container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.container.Controls.Add(this.msg);
            this.container.Controls.Add(this.userAvatar);
            this.container.Location = new System.Drawing.Point(3, 3);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(274, 65);
            this.container.TabIndex = 4;
            // 
            // fileRichTextBox
            // 
            this.fileRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.fileRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileRichTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileRichTextBox.ForeColor = System.Drawing.Color.White;
            this.fileRichTextBox.Location = new System.Drawing.Point(12, 16);
            this.fileRichTextBox.Name = "fileRichTextBox";
            this.fileRichTextBox.Size = new System.Drawing.Size(150, 20);
            this.fileRichTextBox.TabIndex = 2;
            this.fileRichTextBox.Text = "Hello World";
            this.fileRichTextBox.Click += new System.EventHandler(this.fileRichTextBox_Click);
            // 
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.Transparent;
            this.msg.BorderRadius = 15;
            this.msg.Controls.Add(this.fileRichTextBox);
            this.msg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.msg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.msg.Location = new System.Drawing.Point(64, 5);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(200, 50);
            this.msg.TabIndex = 3;
            // 
            // FileMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "FileMessage";
            this.Size = new System.Drawing.Size(282, 68);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.msg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel userAvatar;
        private DevExpress.XtraEditors.PanelControl container;
        private System.Windows.Forms.RichTextBox fileRichTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel msg;
    }
}
