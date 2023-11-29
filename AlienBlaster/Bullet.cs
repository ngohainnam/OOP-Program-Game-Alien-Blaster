namespace AlienBlaster
{
    // Bullet is a class that represents bullets fired by either the space ship or monsters
    public class Bullet : GameObject
    {
        // Indicates whether the bullet is fired by the space ship (default is false)
        public bool IsSpaceShip { get; set; } = false;

        // Constructor for the Bullet class, taking a PictureBox as the game image
        public Bullet(PictureBox GameImage) : base(GameImage)
        {
            Speed = 20; // Set the initial speed of the bullet
        }

        // Move the bullet's position based on whether it's from the space ship or monsters
        public override void Move()
        {
            if (IsSpaceShip)
            {
                // If it's a space ship bullet, move upwards
                GameImage.Top -= Speed;

                // Dispose of the bullet if it goes off the top of the screen
                if (GameImage.Top < 0)
                {
                    GameImage.Dispose();
                }
            }
            else // For monster bullets
            {
                Speed = 10; // Reduce speed for monster bullets
                GameImage.Top += Speed;

                // Dispose of the bullet if it goes off the bottom of the screen
                if (GameImage.Top > 700)
                {
                    GameImage.Dispose();
                }
            }
        }

        // Attack method not used for bullets
        public override void Attack() { }

        // Set the initial position of the bullet
        public void Shoot(int startX, int startY)
        {
            // Set the bullet's location based on the start X and Y positions
            GameImage.Location = new Point(startX - (GameImage.Width / 2), startY);
        }
    }
}
