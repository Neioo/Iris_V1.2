namespace Iris_V1._1.Chat_components
{
    partial class Contacts
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbImageIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImageIcon).BeginInit();
            SuspendLayout();
            // 
            // pbImageIcon
            // 
            pbImageIcon.ImageRotate = 0F;
            pbImageIcon.Location = new Point(12, 12);
            pbImageIcon.Name = "pbImageIcon";
            pbImageIcon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pbImageIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbImageIcon.Size = new Size(55, 51);
            pbImageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImageIcon.TabIndex = 0;
            pbImageIcon.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(73, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 17);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblName);
            Controls.Add(pbImageIcon);
            Name = "Contacts";
            Size = new Size(260, 73);
            ((System.ComponentModel.ISupportInitialize)pbImageIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbImageIcon;
        private Label lblName;
    }
}
