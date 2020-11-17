using System;
using System.Windows.Forms;

namespace Thoroid
{
    public partial class Window : Form
    {
        private Toroid tor;

        public Window()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, System.EventArgs e)
        {
            tor = new Toroid(Convert.ToInt32(textBoxApproximationBig.Text),
            Convert.ToInt32(textBoxApproximationSmall.Text),
            Convert.ToInt32(textBoxRadiusBig.Text),
            Convert.ToInt32(textBoxRadiusSmall.Text), ref pictureBox);
            tor.Update();
        }
    }
}
