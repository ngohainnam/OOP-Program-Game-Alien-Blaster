using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AlienBlaster
{
    // FireMonster is a class that represents monsters that move downward and have no attack
    public class FireMonster : Alien
    {
        // Constructor for the FireMonster class, taking a PictureBox as the game image
        public FireMonster(PictureBox GameImage) : base(GameImage)
        {
            Speed = 5; // Set the initial speed of the fire monster
        }

        // Move the fire monster's position downward
        public override void Move()
        {
            GameImage.Top += Speed;

            // Dispose of the fire monster if it goes off the bottom of the screen
            if (GameImage.Top > 700)
            {
                GameImage.Dispose();
            }
        }

        // Attack method not used for fire monsters
        public override void Attack() { }

        // Create a new FireMonster instance based on the provided game image
        public static FireMonster Spawn(PictureBox GameImage)
        {
            // Create a new PictureBox for the fire monster
            PictureBox monsterImage = new PictureBox();
            monsterImage.Image = GameImage.Image;
            monsterImage.SizeMode = GameImage.SizeMode;
            monsterImage.Size = GameImage.Size;
            monsterImage.Name = "firemonster";

            // Return a new FireMonster instance with the created PictureBox
            return new FireMonster(monsterImage);
        }
    }
}
