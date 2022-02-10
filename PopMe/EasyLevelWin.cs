using System.Windows.Forms;

namespace PopMe
{
    public partial class EasyLevelWin : Form
    {
        public EasyLevelWin()
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
