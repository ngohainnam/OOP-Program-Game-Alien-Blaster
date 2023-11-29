using AlienBlaster;

// The SimpleCollisionStrategy class is responsible for handling collisions in the game.
public class SimpleCollisionStrategy : ICollisionStrategy
{
    private IGame game; // Reference to the game (either SingleMode or MultiMode)

    // Constructor that takes a reference to the game implementing the IGame interface.
    public SimpleCollisionStrategy(IGame game)
    {
        this.game = game;
    }

    // Handle collisions between the spaceship, bullets, and aliens.
    public void HandleCollisions(SpaceShip spaceship, List<Alien> aliens, Label scoreLabel, Label damagedLabel)
    {
        foreach (Bullet playerBullet in spaceship.GetBullets().ToList())
        {
            foreach (Alien alien in aliens.ToList())
            {
                if (playerBullet.GameImage.Bounds.IntersectsWith(alien.GameImage.Bounds))
                {
                    // If the alien is an AcidMonster, handle its bullets.
                    if (alien is AcidMonster acidMonster)
                    {
                        foreach (Bullet bullet in acidMonster.GetBullets().ToList())
                        {
                            RemoveBullet(bullet);
                        }
                        acidMonster.GetBullets().Clear();
                    }

                    // Remove the alien and the player's bullet upon collision.
                    RemoveMonster(alien, aliens);
                    RemoveBullet(playerBullet);

                    // Update the game's score through the IGame interface.
                    game.Score++;
                    scoreLabel.Text = "Score: " + game.Score.ToString();
                }
            }
        }

        foreach (Alien alien in aliens.ToList())
        {
            if (spaceship.GameImage.Bounds.IntersectsWith(alien.GameImage.Bounds))
            {
                // Remove the alien upon collision with the spaceship and update damage.
                RemoveMonster(alien, aliens);
                game.Damage += 5;

                // Update damage displayed in the game.
                damagedLabel.Text = "Damaged: " + game.Damage.ToString();
            }

            if (alien.GameImage.Top > 600)
            {
                // Remove the alien that goes below the game window and update damage.
                game.Damage += 10;

                // Update damage displayed in the game.
                damagedLabel.Text = "Damaged: " + game.Damage.ToString();
                RemoveMonster(alien, aliens);
            }
        }
    }

    // Remove the alien from the game and dispose of its image.
    private void RemoveMonster(Alien alien, List<Alien> aliens)
    {
        aliens.Remove(alien);
        alien.GameImage.Dispose();
    }

    // Dispose of the bullet image.
    private void RemoveBullet(Bullet bullet)
    {
        bullet.GameImage.Dispose();
    }
}
