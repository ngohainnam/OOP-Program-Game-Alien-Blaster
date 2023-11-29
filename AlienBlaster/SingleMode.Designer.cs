namespace AlienBlaster
{
    partial class SingleMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleMode));
            player1 = new PictureBox();
            MovementTimer = new System.Windows.Forms.Timer(components);
            bullet1 = new PictureBox();
            flashmonster = new PictureBox();
            acidbullet = new PictureBox();
            firemonster = new PictureBox();
            scorelabel1 = new Label();
            destroyed = new PictureBox();
            damagedlabel = new Label();
            gameover = new Label();
            acidmonster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flashmonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acidbullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firemonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destroyed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acidmonster).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.BackColor = Color.Transparent;
            player1.Image = Properties.Resources.player1;
            player1.Location = new Point(294, 430);
            player1.Name = "player1";
            player1.Size = new Size(60, 60);
            player1.SizeMode = PictureBoxSizeMode.CenterImage;
            player1.TabIndex = 0;
            player1.TabStop = false;
            player1.Tag = "player";
            // 
            // MovementTimer
            // 
            MovementTimer.Enabled = true;
            MovementTimer.Interval = 20;
            MovementTimer.Tick += MovementTimer_Tick;
            // 
            // bullet1
            // 
            bullet1.BackColor = Color.Transparent;
            bullet1.Image = Properties.Resources.shot;
            bullet1.Location = new Point(309, 388);
            bullet1.Name = "bullet1";
            bullet1.Size = new Size(28, 36);
            bullet1.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet1.TabIndex = 1;
            bullet1.TabStop = false;
            bullet1.Tag = "bullet";
            bullet1.Visible = false;
            // 
            // flashmonster
            // 
            flashmonster.BackColor = Color.Transparent;
            flashmonster.Image = Properties.Resources.Nautolan_Ship___Support___Base;
            flashmonster.Location = new Point(290, 98);
            flashmonster.Name = "flashmonster";
            flashmonster.Size = new Size(64, 64);
            flashmonster.SizeMode = PictureBoxSizeMode.AutoSize;
            flashmonster.TabIndex = 2;
            flashmonster.TabStop = false;
            flashmonster.Tag = "alien";
            flashmonster.Visible = false;
            // 
            // acidbullet
            // 
            acidbullet.BackColor = Color.Transparent;
            acidbullet.Image = Properties.Resources.turbo_green;
            acidbullet.Location = new Point(511, 171);
            acidbullet.Name = "acidbullet";
            acidbullet.Size = new Size(15, 13);
            acidbullet.SizeMode = PictureBoxSizeMode.AutoSize;
            acidbullet.TabIndex = 4;
            acidbullet.TabStop = false;
            acidbullet.Tag = "bullet";
            acidbullet.Visible = false;
            // 
            // firemonster
            // 
            firemonster.BackColor = Color.Transparent;
            firemonster.Image = (Image)resources.GetObject("firemonster.Image");
            firemonster.Location = new Point(76, 98);
            firemonster.Name = "firemonster";
            firemonster.Size = new Size(56, 58);
            firemonster.SizeMode = PictureBoxSizeMode.Zoom;
            firemonster.TabIndex = 5;
            firemonster.TabStop = false;
            firemonster.Tag = "alien";
            firemonster.Visible = false;
            // 
            // scorelabel1
            // 
            scorelabel1.AutoSize = true;
            scorelabel1.BackColor = Color.Transparent;
            scorelabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            scorelabel1.ForeColor = SystemColors.ButtonFace;
            scorelabel1.Location = new Point(12, 9);
            scorelabel1.Name = "scorelabel1";
            scorelabel1.Size = new Size(74, 23);
            scorelabel1.TabIndex = 6;
            scorelabel1.Text = "Score: 0";
            // 
            // destroyed
            // 
            destroyed.BackColor = Color.Transparent;
            destroyed.Image = Properties.Resources.Space_Ships_Explosion;
            destroyed.Location = new Point(265, 504);
            destroyed.Name = "destroyed";
            destroyed.Size = new Size(120, 137);
            destroyed.SizeMode = PictureBoxSizeMode.Zoom;
            destroyed.TabIndex = 7;
            destroyed.TabStop = false;
            destroyed.Visible = false;
            // 
            // damagedlabel
            // 
            damagedlabel.AutoSize = true;
            damagedlabel.BackColor = Color.Transparent;
            damagedlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            damagedlabel.ForeColor = Color.LightSalmon;
            damagedlabel.Location = new Point(546, 9);
            damagedlabel.Name = "damagedlabel";
            damagedlabel.Size = new Size(108, 23);
            damagedlabel.TabIndex = 8;
            damagedlabel.Text = "Damaged: 0";
            // 
            // gameover
            // 
            gameover.AutoSize = true;
            gameover.BackColor = Color.Transparent;
            gameover.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gameover.ForeColor = Color.FromArgb(255, 255, 192);
            gameover.Location = new Point(37, 311);
            gameover.Name = "gameover";
            gameover.Size = new Size(105, 23);
            gameover.TabIndex = 9;
            gameover.Text = "Game Over!";
            gameover.Visible = false;
            // 
            // acidmonster
            // 
            acidmonster.BackColor = Color.Transparent;
            acidmonster.Image = Properties.Resources.Nairan___Frigate___Base;
            acidmonster.Location = new Point(490, 92);
            acidmonster.Name = "acidmonster";
            acidmonster.Size = new Size(64, 64);
            acidmonster.SizeMode = PictureBoxSizeMode.AutoSize;
            acidmonster.TabIndex = 10;
            acidmonster.TabStop = false;
            acidmonster.Visible = false;
            // 
            // SingleMode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 653);
            Controls.Add(acidmonster);
            Controls.Add(gameover);
            Controls.Add(scorelabel1);
            Controls.Add(damagedlabel);
            Controls.Add(destroyed);
            Controls.Add(firemonster);
            Controls.Add(flashmonster);
            Controls.Add(player1);
            Controls.Add(bullet1);
            Controls.Add(acidbullet);
            DoubleBuffered = true;
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "SingleMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alien Blaster (Singleplayer)";
            KeyDown += SingleMode_KeyDown;
            KeyUp += SingleMode_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flashmonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)acidbullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)firemonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)destroyed).EndInit();
            ((System.ComponentModel.ISupportInitialize)acidmonster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player1;
        private System.Windows.Forms.Timer MovementTimer;
        private PictureBox bullet1;
        private PictureBox flashmonster;
        private PictureBox acidbullet;
        private PictureBox firemonster;
        private Label scorelabel1;
        private PictureBox destroyed;
        private Label damagedlabel;
        private Label gameover;
        private PictureBox acidmonster;
    }
}