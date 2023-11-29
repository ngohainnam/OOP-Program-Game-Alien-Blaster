using System.Media;

namespace AlienBlaster
{
    // The SpaceShip class represents the player's spaceship in the game.
    public class SpaceShip : GameObject
    {
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private readonly List<Bullet> bullets = new List<Bullet>();
        private readonly PictureBox bulletImage;

        // Constructor that initializes the spaceship's game image and bullet image.
        public SpaceShip(PictureBox gameImage, PictureBox bulletImage) : base(gameImage)
        {
            Speed = 10;
            this.bulletImage = bulletImage;
        }

        // Handle key press events.
        public void HandleKeyPressed(Keys key)
        {
            pressedKeys.Add(key);
        }

        // Handle key release events and trigger attacks.
        public void HandleKeyReleased(Keys key)
        {
            pressedKeys.Remove(key);

            // Check if it's the first player's spaceship.
            if (GameImage.Name == "player1")
            {
                if (key == Keys.Space)
                {
                    Attack();
                }
            }

            // Check if it's the second player's spaceship.
            if (GameImage.Name == "player2")
            {
                if (key == Keys.NumPad0)
                {
                    Attack();
                }
            }
        }

        // Move the spaceship based on pressed keys.
        public override void Move()
        {
            int formWidth = GameImage.Parent.Width;
            int formHeight = GameImage.Parent.Height;

            // Check if it's the first player's spaceship.
            if (GameImage.Name == "player1")
            {
                foreach (Keys key in pressedKeys)
                {
                    switch (key)
                    {
                        case Keys.W:
                            if (GameImage.Top > 10)
                            {
                                GameImage.Top -= Speed;
                            }
                            break;
                        case Keys.S:
                            if (GameImage.Top + GameImage.Height < formHeight - 40)
                            {
                                GameImage.Top += Speed;
                            }
                            break;
                        case Keys.A:
                            if (GameImage.Left > 10)
                            {
                                GameImage.Left -= Speed;
                            }
                            break;
                        case Keys.D:
                            if (GameImage.Left + GameImage.Width < formWidth - 20)
                            {
                                GameImage.Left += Speed;
                            }
                            break;
                    }
                }
            }

            // Check if it's the second player's spaceship.
            if (GameImage.Name == "player2")
            {
                foreach (Keys key in pressedKeys)
                {
                    switch (key)
                    {
                        case Keys.Up:
                            if (GameImage.Top > 10)
                            {
                                GameImage.Top -= Speed;
                            }
                            break;
                        case Keys.Down:
                            if (GameImage.Top + GameImage.Height < formHeight - 40)
                            {
                                GameImage.Top += Speed;
                            }
                            break;
                        case Keys.Left:
                            if (GameImage.Left > 10)
                            {
                                GameImage.Left -= Speed;
                            }
                            break;
                        case Keys.Right:
                            if (GameImage.Left + GameImage.Width < formWidth - 20)
                            {
                                GameImage.Left += Speed;
                            }
                            break;
                    }
                }
            }
        }

        // Trigger an attack by creating a new bullet.
        public override void Attack()
        {
            // Create a new bullet
            PictureBox bulletPic = new PictureBox();
            bulletPic.Image = bulletImage.Image;
            bulletPic.SizeMode = PictureBoxSizeMode.CenterImage;
            bulletPic.Size = new Size(28, 36);
            bulletPic.BackColor = Color.Transparent;

            bulletImage.Parent.Controls.Add(bulletPic);  // Add to the parent of the template

            Bullet bullet = new Bullet(bulletPic);
            bullet.IsSpaceShip = true;
            int spaceshipCenterX = GameImage.Left + (GameImage.Width / 2);
            int spaceshipCenterY = GameImage.Top + (GameImage.Height / 2);
            bullet.Shoot(spaceshipCenterX, spaceshipCenterY);
            bullets.Add(bullet);
        }

        // Get the list of bullets fired by the spaceship.
        public List<Bullet> GetBullets()
        {
            return bullets;
        }
    }
}
