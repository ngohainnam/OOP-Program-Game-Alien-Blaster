using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienBlaster
{
    // This interface defines the contract for a game (SingleMode or MultiMode).
    public interface IGame
    {
        // The current score of the game.
        int Score { get; set; }

        // The amount of damage the game has sustained.
        int Damage { get; set; }

        // The label displaying the game score.
        Label ScoreLabel { get; }

        // The label displaying the game's damage status.
        Label DamagedLabel { get; }

        // The list of aliens present in the game.
        List<Alien> Aliens { get; }
    }
}
