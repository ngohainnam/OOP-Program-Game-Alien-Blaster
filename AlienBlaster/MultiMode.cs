using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Net.Mime.MediaTypeNames;
using static System.Formats.Asn1.AsnWriter;

namespace AlienBlaster
{
    public partial class MultiMode : Form, IGame
    {
        private SimpleCollisionStrategy collisionStrategy;
        private SpaceShip spaceship1;
        private SpaceShip spaceship2;
        private List<Alien> aliens = new List<Alien>();
        private Random random = new Random();
        SoundPlayer backgroundsound = new SoundPlayer(Properties.Resources.ingametheme);

        // Implement the IGame interface members
        // Represents the player's score.
        private int _score;

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }

        // Represents the player's damage.
        private int _damage;

        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        // Represents the label displaying the player's score.
        public Label ScoreLabel
        {
            get
            {
                return scorelabel1;
            }
        }

        // Represents the label displaying the player's damage.
        public Label DamagedLabel
        {
            get
            {
                return damagedlabel;
            }
        }

        // Represents the list of aliens in the game.
        public List<Alien> Aliens
        {
            get
            {
                return aliens;
            }
        }


        public MultiMode()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            backgroundsound.PlayLooping();
            spaceship1 = new SpaceShip(player1, bullet1);
            spaceship2 = new SpaceShip(player2, bullet2);

            // Create a common collision strategy for both spaceships
            collisionStrategy = new SimpleCollisionStrategy(this);
        }

        private void MultiMode_KeyUp(object sender, KeyEventArgs e)
        {
            spaceship1.HandleKeyReleased(e.KeyCode);
            spaceship2.HandleKeyReleased(e.KeyCode);
        }

        private void MultiMode_KeyDown(object sender, KeyEventArgs e)
        {
            spaceship1.HandleKeyPressed(e.KeyCode);
            spaceship2.HandleKeyPressed(e.KeyCode);
        }

        private void HandleSpaceShipMovements(SpaceShip spaceship)
        {
            spaceship.Move();
            foreach (Bullet bullet in spaceship.GetBullets())
            {
                bullet.Move();
            }
        }

        private void MovementTimer_Tick_1(object sender, EventArgs e)
        {
            spaceship1.Move();
            spaceship2.Move();

            HandleSpaceShipMovements(spaceship1);
            HandleSpaceShipMovements(spaceship2);

            AlienHandler();
            CheckCollisions();

            // Check game over condition
            if (Damage >= 100)
            {
                EndGame();
            }
        }

        private void CheckCollisions()
        {
            collisionStrategy.HandleCollisions(spaceship1, aliens, scorelabel1, damagedlabel);
            collisionStrategy.HandleCollisions(spaceship2, aliens, scorelabel2, damagedlabel2);
        }

        private void AlienHandler()
        {
            Alien? newMonster = null;

            // chance to spawn the flash monster
            if (random.Next(0, 50) == 1)
            {
                newMonster = MonsterFactory.CreateMonster(flashmonster, null);
            }
            // chance to spawn the acid monster
            else if (random.Next(0, 100) == 10)
            {
                newMonster = MonsterFactory.CreateMonster(acidmonster, acidbullet);
            }
            // chance to spawn the fire monster
            else if (random.Next(0, 50) == 10)
            {
                newMonster = MonsterFactory.CreateMonster(firemonster, null);
            }

            if (newMonster != null)
            {
                this.Controls.Add(newMonster.GameImage);
                aliens.Add(newMonster);
            }

            foreach (Alien alien in aliens.ToList())
            {
                alien.Move();

                // For acid monster
                if (alien is AcidMonster acidMonster)
                {
                    acidMonster.MoveBullets();
                }

                if (alien.GameImage.Top > 100)
                {
                    alien.Attack();
                }
                if (alien.GameImage.Top > this.Height)
                {
                    this.Controls.Remove(alien.GameImage);
                    alien.GameImage.Dispose();
                    aliens.Remove(alien);
                }
            }
        }

        private void EndGame()
        {
            gameover.Visible = true;
            gameover.Text = "Game Over!";
            MovementTimer.Stop();
            return;
        }
    }
}
