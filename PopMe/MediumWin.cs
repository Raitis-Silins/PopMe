using System.Windows.Forms;

namespace PopMe
{
    public partial class MediumWin : Form
    {
        public MediumWin()
        {
            InitializeComponent();
        }

        private void EscapeButton(object sender, KeyPressEventArgs e)
        {
            Hide();
            Levels levels = new Levels();
            levels.Show();
        }
    }
}
