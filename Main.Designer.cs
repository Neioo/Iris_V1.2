﻿namespace Iris_V1._1
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1 = new Panel();
            btnGreet = new Guna.UI2.WinForms.Guna2Button();
            gbtnLogOut = new Guna.UI2.WinForms.Guna2Button();
            gbtnAbout = new Guna.UI2.WinForms.Guna2Button();
            gbtnChats = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            pbProfilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            applicationPanel = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 168, 218);
            panel1.Controls.Add(btnGreet);
            panel1.Controls.Add(gbtnLogOut);
            panel1.Controls.Add(gbtnAbout);
            panel1.Controls.Add(gbtnChats);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pbProfilePic);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(265, 759);
            panel1.MinimumSize = new Size(72, 759);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 759);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnGreet
            // 
            btnGreet.CustomizableEdges = customizableEdges1;
            btnGreet.DisabledState.BorderColor = Color.DarkGray;
            btnGreet.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGreet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGreet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGreet.FillColor = Color.Transparent;
            btnGreet.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGreet.ForeColor = Color.White;
            btnGreet.Location = new Point(79, 74);
            btnGreet.Name = "btnGreet";
            btnGreet.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGreet.Size = new Size(180, 45);
            btnGreet.TabIndex = 15;
            btnGreet.Text = "Hello, ";
            btnGreet.Click += btnGreet_Click;
            // 
            // gbtnLogOut
            // 
            gbtnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbtnLogOut.BackColor = Color.Transparent;
            gbtnLogOut.CustomizableEdges = customizableEdges3;
            gbtnLogOut.DisabledState.BorderColor = Color.DarkGray;
            gbtnLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtnLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtnLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtnLogOut.FillColor = Color.Transparent;
            gbtnLogOut.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbtnLogOut.ForeColor = Color.White;
            gbtnLogOut.Image = (Image)resources.GetObject("gbtnLogOut.Image");
            gbtnLogOut.ImageAlign = HorizontalAlignment.Left;
            gbtnLogOut.ImageSize = new Size(40, 40);
            gbtnLogOut.Location = new Point(0, 689);
            gbtnLogOut.Name = "gbtnLogOut";
            gbtnLogOut.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbtnLogOut.Size = new Size(265, 70);
            gbtnLogOut.TabIndex = 13;
            gbtnLogOut.Text = "Log out";
            gbtnLogOut.Click += gbtnLogOut_Click;
            // 
            // gbtnAbout
            // 
            gbtnAbout.BackColor = Color.Transparent;
            gbtnAbout.CustomizableEdges = customizableEdges5;
            gbtnAbout.DisabledState.BorderColor = Color.DarkGray;
            gbtnAbout.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtnAbout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtnAbout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtnAbout.FillColor = Color.Transparent;
            gbtnAbout.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbtnAbout.ForeColor = Color.White;
            gbtnAbout.Image = (Image)resources.GetObject("gbtnAbout.Image");
            gbtnAbout.ImageAlign = HorizontalAlignment.Left;
            gbtnAbout.ImageSize = new Size(40, 40);
            gbtnAbout.Location = new Point(3, 321);
            gbtnAbout.Name = "gbtnAbout";
            gbtnAbout.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbtnAbout.Size = new Size(262, 94);
            gbtnAbout.TabIndex = 8;
            gbtnAbout.Text = "About";
            gbtnAbout.Click += gbtnAbout_Click;
            // 
            // gbtnChats
            // 
            gbtnChats.BackColor = Color.Transparent;
            gbtnChats.CustomizableEdges = customizableEdges7;
            gbtnChats.DisabledState.BorderColor = Color.DarkGray;
            gbtnChats.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtnChats.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtnChats.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtnChats.FillColor = Color.Transparent;
            gbtnChats.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbtnChats.ForeColor = Color.White;
            gbtnChats.Image = (Image)resources.GetObject("gbtnChats.Image");
            gbtnChats.ImageAlign = HorizontalAlignment.Left;
            gbtnChats.ImageSize = new Size(40, 40);
            gbtnChats.Location = new Point(3, 221);
            gbtnChats.Name = "gbtnChats";
            gbtnChats.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gbtnChats.Size = new Size(262, 94);
            gbtnChats.TabIndex = 6;
            gbtnChats.Text = "Chats";
            gbtnChats.Click += gbtnChats_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 86);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 3;
            label3.Text = "Hello,";
            // 
            // pbProfilePic
            // 
            pbProfilePic.ImageRotate = 0F;
            pbProfilePic.Location = new Point(12, 77);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.ShadowDecoration.CustomizableEdges = customizableEdges9;
            pbProfilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbProfilePic.Size = new Size(45, 42);
            pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfilePic.TabIndex = 2;
            pbProfilePic.TabStop = false;
            pbProfilePic.Click += is_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 86);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += is_Clicked;
            // 
            // timer1
            // 
            // 
            // applicationPanel
            // 
            applicationPanel.Dock = DockStyle.Fill;
            applicationPanel.Location = new Point(265, 0);
            applicationPanel.Name = "applicationPanel";
            applicationPanel.Size = new Size(894, 759);
            applicationPanel.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1159, 759);
            Controls.Add(applicationPanel);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iris";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProfilePic;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button gbtnAbout;
        private Guna.UI2.WinForms.Guna2Button gbtnChats;
        private Guna.UI2.WinForms.Guna2Button gbtnLogOut;
        private System.Windows.Forms.Timer timer1;
        private Panel applicationPanel;
        private Guna.UI2.WinForms.Guna2Button btnGreet;
        private System.Windows.Forms.Timer timer2;
    }
}