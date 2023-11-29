namespace AlienBlaster
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
            SingleButton = new Button();
            MultiButton = new Button();
            SuspendLayout();
            // 
            // SingleButton
            // 
            SingleButton.BackgroundImage = Properties.Resources.singlebutton;
            SingleButton.BackgroundImageLayout = ImageLayout.Zoom;
            SingleButton.Location = new Point(151, 355);
            SingleButton.Name = "SingleButton";
            SingleButton.Size = new Size(139, 74);
            SingleButton.TabIndex = 0;
            SingleButton.Text = "\r\n";
            SingleButton.UseVisualStyleBackColor = true;
            SingleButton.Click += SingleButton_Click;
            // 
            // MultiButton
            // 
            MultiButton.BackColor = Color.Transparent;
            MultiButton.BackgroundImage = Properties.Resources.multibutton;
            MultiButton.BackgroundImageLayout = ImageLayout.Zoom;
            MultiButton.Location = new Point(409, 355);
            MultiButton.Name = "MultiButton";
            MultiButton.Size = new Size(144, 74);
            MultiButton.TabIndex = 1;
            MultiButton.UseVisualStyleBackColor = false;
            MultiButton.Click += MultiButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu;
            ClientSize = new Size(682, 653);
            Controls.Add(MultiButton);
            Controls.Add(SingleButton);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alien Blaster";
            ResumeLayout(false);
        }

        #endregion

        private Button SingleButton;
        private Button MultiButton;
    }
}