using System;
using System.Windows.Forms;
using System.Media;

namespace StupidPlayer1._0
{
    public partial class StupidForm : Form
    {
        public StupidForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = audioPath.Text;
                SoundPlayer snd = new SoundPlayer(path);
                snd.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't play the audio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = audioPath.Text;
                SoundPlayer snd = new SoundPlayer(path);
                snd.Stop();
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't stop the audio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = audioPath.Text;
                SoundPlayer snd = new SoundPlayer(path);
                snd.PlayLooping();
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't play the audio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}