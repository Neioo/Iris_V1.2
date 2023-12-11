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
            flowLayoutPanel1 = new FlowLayoutPanel();
            contacts1 = new Chat_components.Contacts();
            lblEmail = new Label();
            flowLayoutPanel1.SuspendLayout();
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
            contacts1.Size = new Size(260, 93);
            contacts1.TabIndex = 0;
            contacts1.Title = null;
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
            // Chats
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEmail);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Chats";
            Size = new Size(894, 759);
            Load += Chats_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Chat_components.Contacts contacts1;
        private Label lblEmail;
    }
}
