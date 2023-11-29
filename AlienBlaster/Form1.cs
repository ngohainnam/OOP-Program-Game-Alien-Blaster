using System.Media;
using System.Numerics;

namespace AlienBlaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer themesong = new SoundPlayer(Properties.Resources.menutheme);//Use your own filename in place of _15035
            themesong.PlayLooping();
        }

        private void SingleButton_Click(object sender, EventArgs e)
        {
            // Create an instance of SingleMode.
            SingleMode singlewindow = new SingleMode();

            // Hide the current form.
            this.Hide();

            // Show single as a modal dialog
            singlewindow.ShowDialog();

            // Show the current form.
            this.Show();
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            // Create an instance of SingleMode.
            MultiMode multiwindow = new MultiMode();

            // Hide the current form.
            this.Hide();

            // Show single as a modal dialog
            multiwindow.ShowDialog();

            // Show the current form.
            this.Show();
        }
    }
}