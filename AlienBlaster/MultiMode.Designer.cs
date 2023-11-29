namespace AlienBlaster
{
    partial class MultiMode
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
            player1 = new PictureBox();
            bullet1 = new PictureBox();
            player2 = new PictureBox();
            bullet2 = new PictureBox();
            acidmonster = new PictureBox();
            firemonster = new PictureBox();
            flashmonster = new PictureBox();
            acidbullet = new PictureBox();
            scorelabel1 = new Label();
            scorelabel2 = new Label();
            gameover = new Label();
            MovementTimer = new System.Windows.Forms.Timer(components);
            damagedlabel2 = new Label();
            damagedlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acidmonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firemonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flashmonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acidbullet).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.BackColor = Color.Transparent;
            player1.Image = Properties.Resources.ship_61;
            player1.Location = new Point(237, 463);
            player1.Name = "player1";
            player1.Size = new Size(60, 60);
            player1.SizeMode = PictureBoxSizeMode.CenterImage;
            player1.TabIndex = 0;
            player1.TabStop = false;
            // 
            // bullet1
            // 
            bullet1.BackColor = Color.Transparent;
            bullet1.Image = Properties.Resources.shot1;
            bullet1.Location = new Point(252, 409);
            bullet1.Name = "bullet1";
            bullet1.Size = new Size(28, 48);
            bullet1.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet1.TabIndex = 1;
            bullet1.TabStop = false;
            bullet1.Visible = false;
            // 
            // player2
            // 
            player2.BackColor = Color.Transparent;
            player2.Image = Properties.Resources.player2;
            player2.Location = new Point(491, 473);
            player2.Name = "player2";
            player2.Size = new Size(60, 60);
            player2.SizeMode = PictureBoxSizeMode.CenterImage;
            player2.TabIndex = 2;
            player2.TabStop = false;
            // 
            // bullet2
            // 
            bullet2.BackColor = Color.Transparent;
            bullet2.Image = Properties.Resources.turbo_blue;
            bullet2.Location = new Point(511, 425);
            bullet2.Name = "bullet2";
            bullet2.Size = new Size(24, 42);
            bullet2.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet2.TabIndex = 3;
            bullet2.TabStop = false;
            bullet2.Visible = false;
            // 
            // acidmonster
            // 
            acidmonster.BackColor = Color.Transparent;
            acidmonster.Image = Properties.Resources.Nautolan_Ship___Frigate___Base;
            acidmonster.Location = new Point(620, 82);
            acidmonster.Name = "acidmonster";
            acidmonster.Size = new Size(64, 64);
            acidmonster.SizeMode = PictureBoxSizeMode.AutoSize;
            acidmonster.TabIndex = 4;
            acidmonster.TabStop = false;
            acidmonster.Visible = false;
            // 
            // firemonster
            // 
            firemonster.BackColor = Color.Transparent;
            firemonster.Image = Properties.Resources.Kla_ed___Torpedo_Ship___Base;
            firemonster.Location = new Point(156, 82);
            firemonster.Name = "firemonster";
            firemonster.Size = new Size(64, 64);
            firemonster.SizeMode = PictureBoxSizeMode.AutoSize;
            firemonster.TabIndex = 5;
            firemonster.TabStop = false;
            firemonster.Visible = false;
            // 
            // flashmonster
            // 
            flashmonster.BackColor = Color.Transparent;
            flashmonster.Image = Properties.Resources.Nautolan_Ship___Scout___Base;
            flashmonster.Location = new Point(392, 82);
            flashmonster.Name = "flashmonster";
            flashmonster.Size = new Size(64, 64);
            flashmonster.SizeMode = PictureBoxSizeMode.AutoSize;
            flashmonster.TabIndex = 6;
            flashmonster.TabStop = false;
            flashmonster.Visible = false;
            // 
            // acidbullet
            // 
            acidbullet.BackColor = Color.Transparent;
            acidbullet.Image = Properties.Resources.turbo_green1;
            acidbullet.Location = new Point(644, 152);
            acidbullet.Name = "acidbullet";
            acidbullet.Size = new Size(15, 13);
            acidbullet.SizeMode = PictureBoxSizeMode.AutoSize;
            acidbullet.TabIndex = 7;
            acidbullet.TabStop = false;
            acidbullet.Visible = false;
            // 
            // scorelabel1
            // 
            scorelabel1.AutoSize = true;
            scorelabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            scorelabel1.ForeColor = Color.White;
            scorelabel1.Location = new Point(12, 9);
            scorelabel1.Name = "scorelabel1";
            scorelabel1.Size = new Size(74, 23);
            scorelabel1.TabIndex = 8;
            scorelabel1.Text = "Score: 0";
            // 
            // scorelabel2
            // 
            scorelabel2.AutoSize = true;
            scorelabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            scorelabel2.ForeColor = SystemColors.Control;
            scorelabel2.Location = new Point(748, 9);
            scorelabel2.Name = "scorelabel2";
            scorelabel2.Size = new Size(74, 23);
            scorelabel2.TabIndex = 9;
            scorelabel2.Text = "Score: 0";
            // 
            // gameover
            // 
            gameover.AutoSize = true;
            gameover.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            gameover.ForeColor = Color.DarkOrange;
            gameover.Location = new Point(276, 257);
            gameover.Name = "gameover";
            gameover.Size = new Size(299, 62);
            gameover.TabIndex = 11;
            gameover.Text = "Game Over! ";
            gameover.Visible = false;
            // 
            // MovementTimer
            // 
            MovementTimer.Enabled = true;
            MovementTimer.Interval = 40;
            MovementTimer.Tick += MovementTimer_Tick_1;
            // 
            // damagedlabel2
            // 
            damagedlabel2.AutoSize = true;
            damagedlabel2.BackColor = Color.Transparent;
            damagedlabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            damagedlabel2.ForeColor = Color.Red;
            damagedlabel2.Location = new Point(748, 32);
            damagedlabel2.Name = "damagedlabel2";
            damagedlabel2.Size = new Size(108, 23);
            damagedlabel2.TabIndex = 12;
            damagedlabel2.Text = "Damaged: 0";
            // 
            // damagedlabel
            // 
            damagedlabel.AutoSize = true;
            damagedlabel.BackColor = Color.Transparent;
            damagedlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            damagedlabel.ForeColor = Color.Red;
            damagedlabel.Location = new Point(12, 32);
            damagedlabel.Name = "damagedlabel";
            damagedlabel.Size = new Size(108, 23);
            damagedlabel.TabIndex = 10;
            damagedlabel.Text = "Damaged: 0";
            // 
            // MultiMode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 653);
            Controls.Add(damagedlabel2);
            Controls.Add(gameover);
            Controls.Add(player1);
            Controls.Add(player2);
            Controls.Add(scorelabel2);
            Controls.Add(scorelabel1);
            Controls.Add(damagedlabel);
            Controls.Add(bullet1);
            Controls.Add(bullet2);
            Controls.Add(acidmonster);
            Controls.Add(acidbullet);
            Controls.Add(flashmonster);
            Controls.Add(firemonster);
            MaximumSize = new Size(900, 700);
            MinimumSize = new Size(900, 700);
            Name = "MultiMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alien Blaster (Multiplayer)";
            KeyDown += MultiMode_KeyDown;
            KeyUp += MultiMode_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)acidmonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)firemonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)flashmonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)acidbullet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player1;
        private PictureBox bullet1;
        private PictureBox player2;
        private PictureBox bullet2;
        private PictureBox acidmonster;
        private PictureBox firemonster;
        private PictureBox flashmonster;
        private PictureBox acidbullet;
        private Label scorelabel1;
        private Label scorelabel2;
        private Label gameover;
        private System.Windows.Forms.Timer MovementTimer;
        private Label damagedlabel2;
        private Label damagedlabel;
    }
}