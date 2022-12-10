namespace ChatApplication.Views
{
    partial class TextMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextMessage));
            this.container = new DevExpress.XtraEditors.PanelControl();
            this.userAvatar = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.msg = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.messageLabel = new System.Windows.Forms.Label();
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
            this.container.Size = new System.Drawing.Size(268, 59);
            this.container.TabIndex = 2;
            this.container.Resize += new System.EventHandler(this.container_Resize);
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
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.Transparent;
            this.msg.BorderRadius = 15;
            this.msg.Controls.Add(this.messageLabel);
            this.msg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.msg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.msg.Location = new System.Drawing.Point(61, 5);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(200, 50);
            this.msg.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(3, 16);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(97, 19);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Hello world";
            // 
            // TextMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.container);
            this.Name = "TextMessage";
            this.Size = new System.Drawing.Size(273, 65);
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
        private System.Windows.Forms.Label messageLabel;
    }
}
