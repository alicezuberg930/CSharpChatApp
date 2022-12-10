namespace ChatApplication.Views
{
    partial class ImageMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageMessage));
            this.userAvatar = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.container = new DevExpress.XtraEditors.PanelControl();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
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
            // container
            // 
            this.container.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.container.Appearance.Options.UseBackColor = true;
            this.container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.container.Controls.Add(this.imageBox);
            this.container.Controls.Add(this.userAvatar);
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(350, 300);
            this.container.TabIndex = 3;
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Transparent;
            this.imageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBox.BackgroundImage")));
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(60, 5);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(250, 250);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // ImageMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "ImageMessage";
            this.Size = new System.Drawing.Size(383, 333);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel userAvatar;
        private DevExpress.XtraEditors.PanelControl container;
        private System.Windows.Forms.PictureBox imageBox;
    }
}
