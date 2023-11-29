using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienBlaster
{
    // FlashMonster is a class that represents monsters that move downward and have the ability to attack at a higher speed
    public class FlashMonster : Alien
    {
        // Constructor for the FlashMonster class, taking a PictureBox as the game image
        public FlashMonster(PictureBox GameImage) : base(GameImage)
        {
            Speed = 6; // Set the initial speed of the flash monster
        }

        // Move the flash monster's position downward
        public override void Move()
        {
            // Move the FlashMonster downward.
            GameImage.Top += Speed;

            // Dispose of the flash monster if it goes off the bottom of the screen
            if (GameImage.Top > 700)
            {
                GameImage.Dispose();
            }
        }

        // Attack method for flash monsters, doubling the speed for faster movement
        public override void Attack()
        {
            // Set the speed to a higher value for faster attack
            Speed = 20;

            // Move the flash monster downward at the increased speed
            GameImage.Top += Speed;

            // Dispose of the flash monster if it goes off the bottom of the screen
            if (GameImage.Top > 700)
            {
                GameImage.Dispose();
            }
        }

        // Create a new FlashMonster instance based on the provided game image
        public static FlashMonster Spawn(PictureBox GameImage)
        {
            // Create a new PictureBox for the flash monster
            PictureBox monsterImage = new PictureBox();
            monsterImage.Image = GameImage.Image;
            monsterImage.SizeMode = GameImage.SizeMode;
            monsterImage.Size = GameImage.Size;
            monsterImage.Name = "flashmonster";

            // Return a new FlashMonster instance with the created PictureBox
            return new FlashMonster(monsterImage);
        }
    }
}
