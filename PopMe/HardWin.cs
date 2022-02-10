using System.Windows.Forms;

namespace PopMe
{
    public partial class HardWin : Form
    {
        public HardWin()
        {
            InitializeComponent();
        }

        private void EscapeButton(object sender, KeyEventArgs e)
        {
            Hide();
            Levels levels = new Levels();
            levels.Show();
        }
    }
}
