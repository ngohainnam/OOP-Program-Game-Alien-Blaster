using System.Windows.Forms;

namespace AlienBlaster
{
    // The MonsterFactory class is responsible for creating different types of Alien monsters.
    public class MonsterFactory
    {
        // Create a specific type of Alien based on the provided gameImage and bulletImage.
        public static Alien CreateMonster(PictureBox gameImage, PictureBox? bulletImage)
        {
            // Check the name of the gameImage to determine the type of monster to create.
            if (gameImage.Name == "acidmonster")
            {
                // Create an AcidMonster with the provided gameImage and bulletImage.
                return AcidMonster.Spawn(gameImage, bulletImage);
            }
            else if (gameImage.Name == "firemonster")
            {
                // Create a FireMonster with the provided gameImage.
                return FireMonster.Spawn(gameImage);
            }
            else
            {
                // Create a FlashMonster with the provided gameImage.
                return FlashMonster.Spawn(gameImage);
            }
        }
    }
}
