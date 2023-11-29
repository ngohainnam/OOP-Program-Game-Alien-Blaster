using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienBlaster
{
    // This interface defines a contract for collision strategies.
    public interface ICollisionStrategy
    {
        // This method handles collisions between a spaceship, a list of aliens, a score label, and a damage label.
        void HandleCollisions(SpaceShip spaceship, List<Alien> aliens, Label scoreLabel, Label damagedLabel);
    }
}
