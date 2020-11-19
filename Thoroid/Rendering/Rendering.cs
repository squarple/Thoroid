using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Thoroid.Rendering
{
    public class Rendering
    {
        private readonly Pen pen = new Pen(Color.Blue, 1);

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

        public void PointsRendering(ref Points[,] points)
        {
            graph.Clear(Color.Transparent);
            Random random = new Random();
            foreach (var temp in points)
            {
                using (var newPen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), 1))
                {
                    graph.DrawEllipse(newPen, (int)temp.X, (int)temp.Y, 1, 1);
                }
            }
        }

        public void LinesRendering(ref Points[,] realPoints)
        {
            graph.Clear(Color.Transparent);

            coordList = new List<_4Points>();
            coordList = CreatePolygons(realPoints);

            Random random = new Random();

            foreach (var temp in coordList)
            {
                graph.DrawPolygon(pen, temp.Points);
            }
        }

        public void PolygonsRendering(ref Points[,] points)
        {
            //MessageBox.Show("getta fuck out!!!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            graph.Clear(Color.Transparent);

            coordList = new List<_4Points>();   //лист полигонов из 4 точек
            coordList = CreatePolygons(points);

            graph.Clear(Color.Transparent);

            Point[] p = new Point[4];
            double cur = 0;
            double[,] arr = new double[coordList.Count, 2];   //массив 
            for (int i = 0; i < coordList.Count; i++)
            {
                cur = 0;
                cur = (coordList[i].ZArray[0] + coordList[i].ZArray[1] + coordList[i].ZArray[2] + coordList[i].ZArray[3]) / 4;
                arr[i, 0] = cur;
                arr[i, 1] = i;
            }

            double[] NormAngle = new double[coordList.Count];
            for (int m = 0; m < coordList.Count; m++)
            {
                NormAngle[m] = CosNormal(coordList[m]);
            }

            QSort(arr, 0, coordList.Count - 1);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                p[0].X = (int)coordList[(int)arr[i, 1]].Points[0].X;
                p[0].Y = (int)coordList[(int)arr[i, 1]].Points[0].Y;

                p[1].X = (int)coordList[(int)arr[i, 1]].Points[1].X;
                p[1].Y = (int)coordList[(int)arr[i, 1]].Points[1].Y;

                p[2].X = (int)coordList[(int)arr[i, 1]].Points[2].X;
                p[2].Y = (int)coordList[(int)arr[i, 1]].Points[2].Y;

                p[3].X = (int)coordList[(int)arr[i, 1]].Points[3].X;
                p[3].Y = (int)coordList[(int)arr[i, 1]].Points[3].Y;

                int _alpha = Math.Abs((int)(255 * (NormAngle[(int)arr[i, 1]])));
                Color clr = Color.FromArgb(_alpha, 55, 100, 120);
                SolidBrush dr = new SolidBrush(clr);
                graph.FillPolygon(Brushes.Black, p);
                graph.FillPolygon(dr, p);
                //_graph.FillPolygon(Brushes.Aquamarine, p);
                //_graph.DrawPolygon(new Pen(Color.Chartreuse), p);

            }
            //_pic.Image = _bmp;
        }
        private static double CosNormal(_4Points p)
        {
            double[] coord = new double[3];
            coord[0] = (p.Points[1].Y - p.Points[0].Y) * (p.ZArray[2] - p.ZArray[0]) - (p.ZArray[1] - p.ZArray[0]) * (p.Points[2].Y - p.Points[0].Y);  //координаты нормали по x
            coord[1] = (p.ZArray[1] - p.ZArray[0]) * (p.Points[2].X - p.Points[0].X) - (p.Points[1].X - p.Points[0].X) * (p.ZArray[2] - p.ZArray[0]);  //координаты нормали по y
            coord[2] = (p.Points[1].X - p.Points[0].X) * (p.Points[2].Y - p.Points[0].Y) - (p.Points[1].Y - p.Points[0].Y) * (p.Points[2].X - p.Points[0].X);  //координаты нормали по z
            double cos = coord[2] / (Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2) + Math.Pow(coord[2], 2)));
            return cos;
        }
        //эти 2 ф-ции -- сортировка
        private void QSort(double[,] facets, int _in, int _out)
        {
            if (_in >= _out)
                return;
            int temp = Partition(facets, _in, _out);
            QSort(facets, _in, temp - 1);
            QSort(facets, temp + 1, _out);
        }
        private static int Partition(double[,] facets, int _in, int _out)
        {
            int marker = _in;
            for (var i = _in; i <= _out; i++)
            {
                if (facets[i, 0] <= facets[_out, 0])
                {
                    double temp = facets[marker, 0];
                    facets[marker, 0] = facets[i, 0];
                    facets[i, 0] = temp;
                    temp = facets[marker, 1];
                    facets[marker, 1] = facets[i, 1];
                    facets[i, 1] = temp;
                    marker++;
                }
            }
            return marker - 1;
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
