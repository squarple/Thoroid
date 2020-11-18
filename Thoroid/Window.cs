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

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            tor.Move(0, 30, 0);
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            tor.Move(0, -30, 0);
        }

        private void ButtonMoveLeft_Click(object sender, EventArgs e)
        {
            tor.Move(-30, 0, 0);
        }

        private void ButtonMoveRight_Click(object sender, EventArgs e)
        {
            tor.Move(30, 0, 0);
        }

        private void ButtonMoveFromUs_Click(object sender, EventArgs e)
        {
            tor.Move(0, 0, -30);
        }

        private void ButtonMoveToUs_Click(object sender, EventArgs e)
        {
            tor.Move(0, 0, 30);
        }

        private void RadioButtonPoints_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeDrawType(DrawTypeEnum.Points);
        }

        private void RadioButtonLines_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeDrawType(DrawTypeEnum.Lines);
        }

        private void RadioButtonPolygons_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeDrawType(DrawTypeEnum.Polygons);
        }

        private void RadioButtonUsual2D_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Usual);
        }

        private void RadioButtonOblique_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Oblique);
        }

        private void RadioButtonAxonometric_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Axonometric);
        }

        private void RadioButtonPerspective_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Perspective);
        }

        private void RadioButtonOrthogonal_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Orthogonal);
        }

        private void RadioButtonProfile_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Profile);
        }

        private void RadioButtonHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            Toroid.ChangeViewType(ViewTypeEnum.Horizontal);
        }
    }
}
