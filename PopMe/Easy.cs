using System;
using System.Windows.Forms;

namespace PopMe
{
    public partial class Easy : Form
    {
        private int _speed;
        private int _score;
        private Random _random = new Random();
        private bool _gameOver;




        public Easy()
        {
            InitializeComponent();
            RestartGame();
            DoubleBuffered = true;
        }

        private void MainTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + _score;

            if (_gameOver)
            {
                gameTimer.Stop();
                txtScore.Text = "Score: " + _score + " You lost, press enter to restart";
            }

            foreach (Control x in Controls)
            {

                if (x is PictureBox)
                {
                    x.Top -= _speed;

                    if (x.Top < -100)
                    {
                        x.Top = _random.Next(533, 1000);
                        x.Left = _random.Next(4, 400);
                    }

                    if ((string)x.Tag == "face")
                    {

                        if (x.Top < -50)
                        {
                            _gameOver = true;
                        }

                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = _random.Next(588, 900);
                            x.Left = _random.Next(4, 400);
                        }
                    }
                }
            }
        }

        private void Boom(object sender, EventArgs e)
        {
            if (_gameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                _gameOver = true;
            }
        }

        private void PopFace(object sender, EventArgs e)
        {
            if (_gameOver == false)
            {
                var face = (PictureBox)sender;

                face.Top = _random.Next(530, 1000);
                face.Left = _random.Next(4, 400);

                _score += 1;

                if (_score == 100)
                {
                    _gameOver = true;
                    Hide();
                    EasyLevelWin win = new EasyLevelWin();
                    win.Show();
                }
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _gameOver)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            _speed = 5;
            _score = 0;
            _gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = _random.Next(400, 800);
                    x.Left = _random.Next(4, 400);
                }
            }

            gameTimer.Start();
        }
    }
}
