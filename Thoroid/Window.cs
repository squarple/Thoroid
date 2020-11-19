using System;
using System.Windows.Forms;
using Thoroid.Enums;

namespace Thoroid
{
    public partial class Window : Form
    {
        private Toroid tor;

        public Window()
        {
            InitializeComponent();
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            tor = new Toroid(
                Convert.ToInt32(textBoxApproximationBig.Text), 
                Convert.ToInt32(textBoxApproximationSmall.Text),
                Convert.ToInt32(textBoxRadiusBig.Text), 
                Convert.ToInt32(textBoxRadiusSmall.Text), ref pictureBox);
            tor.Update();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Data.ObliqueL = Convert.ToDouble(textBoxObliqueL.Text);
            Data.ObliqueAlpha = Convert.ToDouble(textBoxObliqueAlpha.Text);
            Data.AxonometryPhi = Convert.ToDouble(textBoxAxonometryPhi.Text);
            Data.AxonometryTheta = Convert.ToDouble(textBoxAxonometryTheta.Text);

            Data.PerspectiveD = Convert.ToDouble(textBoxPerspectiveD.Text);
            Data.PerspectivePhi = Convert.ToDouble(textBoxPerspectivePhi.Text);
            Data.PerspectiveTheta = Convert.ToDouble(textBoxPerspectiveTheta.Text);
            Data.PerspectiveRo = Convert.ToDouble(textBoxPerspectiveRo.Text);

            tor.Update();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            tor.Move(
                Convert.ToDouble(textBoxMoveX.Text), 
                Convert.ToDouble(textBoxMoveY.Text),
                Convert.ToDouble(textBoxMoveZ.Text));
        }

        private void ButtonScale_Click(object sender, EventArgs e)
        {
            tor.Scale(
                Convert.ToDouble(textBoxScaleX.Text), 
                Convert.ToDouble(textBoxScaleY.Text),
                Convert.ToDouble(textBoxScaleZ.Text));
        }

        private void ButtonRotate_Click(object sender, EventArgs e)
        {
            tor.Rotate(
                Convert.ToDouble(textBoxRotateX.Text),
                Convert.ToDouble(textBoxRotateY.Text),
                Convert.ToDouble(textBoxRotateZ.Text));
        }

        private void ButtonCustomMove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Text)
            {
                case "left":
                    tor.Move(-30, 0, 0);
                    break;
                case "right":
                    tor.Move(30, 0, 0);
                    break;
                case "up":
                    tor.Move(0, 30, 0);
                    break;
                case "down":
                    tor.Move(0, -30, 0);
                    break;
                case "from us":
                    tor.Move(0, 0, -30);
                    break;
                case "to us":
                    tor.Move(0, 0, 30);
                    break;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var button = (RadioButton) sender;
            switch (button.Text)
            {
                case "Points":
                    Data.DrawType = DrawTypeEnum.Points;
                    break;
                case "Lines":
                    Data.DrawType = DrawTypeEnum.Lines;
                    break;
                case "Polygons":
                    Data.DrawType = DrawTypeEnum.Polygons;
                    break;
                case "Usual":
                    Data.ViewType = ViewTypeEnum.Usual;
                    break;
                case "Oblique":
                    Data.ViewType = ViewTypeEnum.Oblique;
                    break;
                case "Axonometric":
                    Data.ViewType = ViewTypeEnum.Axonometric;
                    break;
                case "Perspective":
                    Data.ViewType = ViewTypeEnum.Perspective;
                    break;
                case "Orthogonal":
                    Data.ViewType = ViewTypeEnum.Orthogonal;
                    break;
                case "Profile":
                    Data.ViewType = ViewTypeEnum.Profile;
                    break;
                case "Horizontal":
                    Data.ViewType = ViewTypeEnum.Horizontal;
                    break;
            }
        }
    }
}
