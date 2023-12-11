namespace Iris_V1._1.Dashboard
{
    partial class Chats
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chats));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contacts1 = new Chat_components.Contacts();
            lblEmail = new Label();
            panel2 = new Panel();
            tbChatbox = new Guna.UI2.WinForms.Guna2TextBox();
            btnSend = new Guna.UI2.WinForms.Guna2Button();
            pbUserTwo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblUserTwo = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            chat1 = new Chat_components.Chat();
            reply1 = new Chat_components.Reply();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(contacts1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(629, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(265, 759);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // contacts1
            // 
            contacts1.BackColor = SystemColors.ActiveCaption;
            contacts1.Dock = DockStyle.Top;
            contacts1.Icon = null;
            contacts1.Location = new Point(3, 3);
            contacts1.Name = "contacts1";
            contacts1.Size = new Size(260, 92);
            contacts1.TabIndex = 0;
            contacts1.Title = null;
            contacts1.Load += contacts1_Load;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 3);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label1";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbChatbox);
            panel2.Controls.Add(btnSend);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 665);
            panel2.Name = "panel2";
            panel2.Size = new Size(629, 94);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // tbChatbox
            // 
            tbChatbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbChatbox.BackColor = SystemColors.Control;
            tbChatbox.BorderRadius = 10;
            tbChatbox.CustomizableEdges = customizableEdges1;
            tbChatbox.DefaultText = "";
            tbChatbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbChatbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbChatbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbChatbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbChatbox.FillColor = Color.WhiteSmoke;
            tbChatbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbChatbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbChatbox.ForeColor = Color.Black;
            tbChatbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbChatbox.Location = new Point(19, 26);
            tbChatbox.Name = "tbChatbox";
            tbChatbox.PasswordChar = '\0';
            tbChatbox.PlaceholderText = "Type message...";
            tbChatbox.SelectedText = "";
            tbChatbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbChatbox.Size = new Size(520, 44);
            tbChatbox.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BorderRadius = 10;
            btnSend.CustomizableEdges = customizableEdges3;
            btnSend.DisabledState.BorderColor = Color.DarkGray;
            btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Image = (Image)resources.GetObject("btnSend.Image");
            btnSend.ImageSize = new Size(25, 25);
            btnSend.Location = new Point(553, 25);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSend.Size = new Size(59, 45);
            btnSend.TabIndex = 0;
            btnSend.Click += guna2Button1_Click;
            // 
            // pbUserTwo
            // 
            pbUserTwo.ImageRotate = 0F;
            pbUserTwo.Location = new Point(11, 8);
            pbUserTwo.Name = "pbUserTwo";
            pbUserTwo.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pbUserTwo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbUserTwo.Size = new Size(42, 37);
            pbUserTwo.TabIndex = 0;
            pbUserTwo.TabStop = false;
            // 
            // lblUserTwo
            // 
            lblUserTwo.AutoSize = true;
            lblUserTwo.ForeColor = Color.White;
            lblUserTwo.Location = new Point(67, 17);
            lblUserTwo.Name = "lblUserTwo";
            lblUserTwo.Size = new Size(58, 19);
            lblUserTwo.TabIndex = 1;
            lblUserTwo.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(577, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblUserTwo);
            panel1.Controls.Add(pbUserTwo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 55);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(chat1);
            flowLayoutPanel2.Controls.Add(reply1);
            flowLayoutPanel2.Location = new Point(0, 61);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(629, 598);
            flowLayoutPanel2.TabIndex = 6;
            flowLayoutPanel2.Visible = false;
            // 
            // chat1
            // 
            chat1.BackColor = SystemColors.ActiveCaption;
            chat1.Location = new Point(4, 4);
            chat1.Margin = new Padding(4);
            chat1.Name = "chat1";
            chat1.Size = new Size(618, 51);
            chat1.TabIndex = 0;
            chat1.Title = null;
            // 
            // reply1
            // 
            reply1.BackColor = SystemColors.ActiveCaption;
            reply1.Icon = null;
            reply1.Location = new Point(3, 62);
            reply1.Name = "reply1";
            reply1.Size = new Size(618, 70);
            reply1.TabIndex = 1;
            reply1.Title = null;
            // 
            // Chats
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblEmail);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Chats";
            Size = new Size(894, 759);
            Load += Chats_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Chat_components.Contacts contacts1;
        private Label lblEmail;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox tbChatbox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserTwo;
        private Label lblUserTwo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Chat_components.Chat chat1;
        private Chat_components.Reply reply1;
    }
}
