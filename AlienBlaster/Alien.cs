using System;
using System.Windows.Forms.Design;

namespace AlienBlaster
{
    public abstract class Alien : GameObject
    {
        private Random random = new Random();

        public Alien(PictureBox gameImage) : base(gameImage)
        {
            // Set the initial X position randomly but dependent on the form's size
            gameImage.Left = random.Next(0, 600);

            // Set the initial Y position to just off the top of the screen.
            gameImage.Top = -gameImage.Height;
        }
    }
}
