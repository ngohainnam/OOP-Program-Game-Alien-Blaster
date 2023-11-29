using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienBlaster
{
    public class AcidMonster : Alien
    {
        // List to hold acid bullets
        private readonly List<Bullet> acidbullets = new List<Bullet>();

        // PictureBox for the acid bullet template
        private readonly PictureBox bulletImage;

        // Constructor for AcidMonster
        public AcidMonster(PictureBox GameImage, PictureBox acidbullet) : base(GameImage)
        {
            // Set the speed of the AcidMonster
            Speed = 8;

            // Store the acid bullet template
            this.bulletImage = acidbullet;
        }

        // Move the AcidMonster downward
        public override void Move()
        {
            // Move the AcidMonster downward
            GameImage.Top += Speed;

            // Dispose of the AcidMonster when it goes out of bounds
            if (GameImage.Top > 700)
            {
                GameImage.Dispose();
            }
        }

        // Attack method to create acid bullets
        public override void Attack()
        {
            // Create a new bullet PictureBox
            PictureBox acidbulletpic = new PictureBox();
            acidbulletpic.Image = bulletImage.Image;
            acidbulletpic.SizeMode = PictureBoxSizeMode.CenterImage;
            acidbulletpic.Size = new Size(28, 36);
            acidbulletpic.BackColor = Color.Transparent;

            // Add the bullet to the parent of the template
            bulletImage.Parent.Controls.Add(acidbulletpic);

            // Create a new bullet object
            Bullet bullet = new Bullet(acidbulletpic);

            // Calculate the center of the AcidMonster
            int spaceshipCenterX = GameImage.Left + (GameImage.Width / 2);
            int spaceshipCenterY = GameImage.Top + (GameImage.Height / 2);

            // Shoot the bullet from the center of the AcidMonster
            bullet.Shoot(spaceshipCenterX, spaceshipCenterY);

            // Add the bullet to the acidbullets list
            acidbullets.Add(bullet);
        }

        // Method to spawn an AcidMonster
        public static AcidMonster Spawn(PictureBox GameImage, PictureBox acidbullet)
        {
            // Create a new PictureBox for the AcidMonster
            PictureBox monsterImage = new PictureBox();
            monsterImage.Image = GameImage.Image;
            monsterImage.SizeMode = GameImage.SizeMode;
            monsterImage.Size = GameImage.Size;
            monsterImage.Name = "acidmonster";

            // Create and return a new AcidMonster
            return new AcidMonster(monsterImage, acidbullet);
        }

        // Get the list of acid bullets
        public List<Bullet> GetBullets()
        {
            return acidbullets;
        }

        // Move all acid bullets
        public void MoveBullets()
        {
            foreach (Bullet bullet in acidbullets)
            {
                bullet.Move();
            }
        }
    }
}
