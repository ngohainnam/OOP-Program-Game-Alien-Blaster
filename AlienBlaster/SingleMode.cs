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
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace AlienBlaster
{
    public partial class SingleMode : Form, IGame
    {
        private SimpleCollisionStrategy collisionStrategy;
        private SpaceShip spaceship;
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

        public SingleMode()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            backgroundsound.PlayLooping();
            collisionStrategy = new SimpleCollisionStrategy(this);
            spaceship = new SpaceShip(player1, bullet1);
        }

        private void SingleMode_KeyUp(object sender, KeyEventArgs e)
        {
            spaceship.HandleKeyReleased(e.KeyCode);
        }

        private void SingleMode_KeyDown(object sender, KeyEventArgs e)
        {
            spaceship.HandleKeyPressed(e.KeyCode);
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            spaceship.Move();

            foreach (Bullet bullet in spaceship.GetBullets())
            {
                bullet.Move();
            }
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
            collisionStrategy.HandleCollisions(spaceship, aliens, scorelabel1, damagedlabel);
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
            gameover.Text = "Game Over! You have destroyed " + Score.ToString() + " aliens. Click (x) to exit and try again.";
            MovementTimer.Stop();

            return;
        }
    }
}
