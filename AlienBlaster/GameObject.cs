using System.Windows.Forms;

namespace AlienBlaster
{
    // GameObject is an abstract class representing game objects in the Alien Blaster game.
    public abstract class GameObject
    {
        private PictureBox _gameImage; // A PictureBox to display the game object.
        private int _speed; // The speed of the game object.

        // Constructor for GameObject, takes a PictureBox representing the game image.
        public GameObject(PictureBox gameImage)
        {
            _gameImage = gameImage;
        }

        // Property to get or set the game image.
        public PictureBox GameImage
        {
            get
            {
                return _gameImage;
            }
            set
            {
                _gameImage = value;
            }
        }

        // Property to get or set the speed of the game object.
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        // Abstract method for moving the game object. Subclasses must implement this method.
        public abstract void Move();

        // Abstract method for handling an attack action by the game object. Subclasses must implement this method.
        public abstract void Attack();
    }
}
