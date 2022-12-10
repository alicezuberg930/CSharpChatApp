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
            this.container = new DevExpress.XtraEditors.PanelControl();
            this.userAvatar = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.msg = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.fileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.SuspendLayout();
            this.msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.container.Appearance.Options.UseBackColor = true;
            this.container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.container.Controls.Add(this.userAvatar);
            this.container.Controls.Add(this.msg);
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(270, 60);
            this.container.TabIndex = 3;
            this.container.Resize += new System.EventHandler(this.container_Resize);
            // 
            // userAvatar
            // 
            this.userAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userAvatar.BackgroundImage")));
            this.userAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userAvatar.BorderRadius = 15;
            this.userAvatar.Location = new System.Drawing.Point(5, 5);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(50, 50);
            this.userAvatar.TabIndex = 1;
            // 
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.Transparent;
            this.msg.BorderRadius = 15;
            this.msg.Controls.Add(this.fileLabel);
            this.msg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.msg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.msg.Location = new System.Drawing.Point(60, 5);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(200, 50);
            this.msg.TabIndex = 0;
            this.msg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.msg_MouseClick);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.White;
            this.fileLabel.Location = new System.Drawing.Point(3, 16);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(97, 19);
            this.fileLabel.TabIndex = 2;
            this.fileLabel.Text = "Hello world";
            // 
            // FileMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FileMessage";
            this.Size = new System.Drawing.Size(363, 168);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.msg.ResumeLayout(false);
            this.msg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl container;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel userAvatar;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel msg;
        private System.Windows.Forms.Label fileLabel;
    }
}
