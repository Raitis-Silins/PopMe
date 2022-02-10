using System;
using System.Windows.Forms;

namespace PopMe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            Levels levels = new Levels();
            levels.Show();
        }
    }
}
