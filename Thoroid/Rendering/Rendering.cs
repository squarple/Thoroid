using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Thoroid.Rendering
{
    public class Rendering
    {
        private readonly Pen _pen = new Pen(Color.Blue, 1);

        private static PictureBox pic;
        private static Bitmap bmp;
        private static Graphics graph;
        private List<_4Points> coordList;

        public Rendering(ref PictureBox pictureBox)
        {
            pic = pictureBox;
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            //pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            //_graph = Graphics.FromImage(pictureBox.Image);
            graph = pictureBox.CreateGraphics();
            //_graph = Graphics.FromImage(_bmp);

            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.TranslateTransform((float)pictureBox.Width / 2, (float)pictureBox.Height / 2);
            graph.ScaleTransform(1, -1);
        }

        public void LinesRendering(ref Points[,] realPoints)
        {
            graph.Clear(Color.Transparent);

            coordList = new List<_4Points>();   //лист полигонов из 4 точек
            coordList = CreatePolygons(realPoints);

            foreach (var temp in coordList)
                graph.DrawPolygon(_pen, temp.points);

            //_pic.Image = _bmp;
        }

        private List<_4Points> CreatePolygons(Points[,] p)
        {
            List<_4Points> list = new List<_4Points>();
            for (var i = 0; i < p.GetLength(0) - 1; i++)
            {
                for (var j = 0; j < p.GetLength(1) - 1; j++)
                {
                    list.Add(new _4Points(p[i, j], p[i, j + 1], p[i + 1, j + 1], p[i + 1, j]));
                }
            }
            return list;
        }
    }
}
