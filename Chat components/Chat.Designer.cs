namespace Iris_V1._1.Chat_components
{
    partial class Chat
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
            lblChat = new Label();
            SuspendLayout();
            // 
            // lblChat
            // 
            lblChat.AutoSize = true;
            lblChat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChat.Location = new Point(109, 20);
            lblChat.Name = "lblChat";
            lblChat.Size = new Size(57, 21);
            lblChat.TabIndex = 0;
            lblChat.Text = "label1";
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblChat);
            Name = "Chat";
            Size = new Size(296, 65);
            Load += Chat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChat;
    }
}
