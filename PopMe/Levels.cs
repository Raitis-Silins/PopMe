using System;
using System.Windows.Forms;

namespace PopMe
{
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void EasyLevel_Click(object sender, EventArgs e)
        {
            Hide();
            Easy easy = new Easy();
            easy.Show();
        }

        private void HardLevel_Click(object sender, EventArgs e)
        {
            Hide();
            Hard hard = new Hard();
            hard.Show();
        }

        private void MediumLevel_Click(object sender, EventArgs e)
        {
            Hide();
            Medium medium = new Medium();
            medium.Show();
        }
    }
}
