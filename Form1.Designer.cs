namespace Iris_V1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            topPanel = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            loginCPanel = new Panel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.BorderRadius = 15;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.Cursor = Cursors.Hand;
            guna2ControlBox2.CustomizableEdges = customizableEdges3;
            guna2ControlBox2.FillColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.Black;
            guna2ControlBox2.Location = new Point(920, 3);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox2.Size = new Size(31, 33);
            guna2ControlBox2.TabIndex = 1;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.WhiteSmoke;
            topPanel.BorderRadius = 10;
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(guna2ControlBox1);
            topPanel.Controls.Add(guna2ControlBox2);
            topPanel.CustomizableEdges = customizableEdges5;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            topPanel.Size = new Size(1000, 40);
            topPanel.TabIndex = 2;
            topPanel.MouseDown += dragForm;
            topPanel.MouseMove += dragMove;
            topPanel.MouseUp += dragStop;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 3;
            label1.Text = "IRIS";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BorderRadius = 15;
            guna2ControlBox1.Cursor = Cursors.Hand;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Transparent;
            guna2ControlBox1.HoverState.BorderColor = Color.Red;
            guna2ControlBox1.HoverState.FillColor = Color.Red;
            guna2ControlBox1.HoverState.IconColor = Color.Black;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(957, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(31, 33);
            guna2ControlBox1.TabIndex = 2;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // loginCPanel
            // 
            loginCPanel.BackColor = Color.White;
            loginCPanel.Dock = DockStyle.Fill;
            loginCPanel.Location = new Point(0, 40);
            loginCPanel.Name = "loginCPanel";
            loginCPanel.Size = new Size(1000, 543);
            loginCPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1000, 583);
            Controls.Add(loginCPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Form1_FormClosing;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Panel loginCPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label1;
    }
}